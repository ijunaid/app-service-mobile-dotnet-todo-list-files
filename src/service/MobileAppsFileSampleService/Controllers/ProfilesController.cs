using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using MobileAppsFileSampleService.DataObjects;
using MobileAppsFileSampleService.Models;

namespace MobileAppsFileSampleService.Controllers
{
	public class ProfilesController : TableController<Profiles>
	{
		protected override void Initialize(HttpControllerContext controllerContext)
		{
			base.Initialize(controllerContext);
			MobileAppsFileSampleContext context = new MobileAppsFileSampleContext();
			DomainManager = new EntityDomainManager<Profiles>(context, Request, enableSoftDelete: true);
		}

		// GET tables/Profiles
		public IQueryable<Profiles> GetAllProfiless()
		{
			return Query();
		}

		// GET tables/Profiles/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public SingleResult<Profiles> GetProfiles(string id)
		{
			return Lookup(id);
		}

		// PATCH tables/Profiles/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public Task<Profiles> PatchProfiles(string id, Delta<Profiles> patch)
		{
			return UpdateAsync(id, patch);
		}

		// POST tables/Profiles
		public async Task<IHttpActionResult> PostProfiles(Profiles item)
		{
			Profiles current = await InsertAsync(item);
			return CreatedAtRoute("Tables", new { id = current.Id }, current);
		}

		// DELETE tables/Profiles/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public Task DeleteProfiles(string id)
		{
			return DeleteAsync(id);
		}
	}
}