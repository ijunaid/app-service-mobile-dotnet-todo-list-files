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
	public class ProfilesIdController : TableController<ProfilesId>
	{
		protected override void Initialize(HttpControllerContext controllerContext)
		{
			base.Initialize(controllerContext);
			MobileAppsFileSampleContext context = new MobileAppsFileSampleContext();
			DomainManager = new EntityDomainManager<ProfilesId>(context, Request, enableSoftDelete: true);
		}

		// GET tables/ProfilesId
		public IQueryable<ProfilesId> GetAllProfilesIds()
		{
			return Query();
		}

		// GET tables/ProfilesId/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public SingleResult<ProfilesId> GetProfilesId(string id)
		{
			return Lookup(id);
		}

		// PATCH tables/ProfilesId/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public Task<ProfilesId> PatchProfilesId(string id, Delta<ProfilesId> patch)
		{
			return UpdateAsync(id, patch);
		}

		// POST tables/ProfilesId
		public async Task<IHttpActionResult> PostProfilesId(ProfilesId item)
		{
			ProfilesId current = await InsertAsync(item);
			return CreatedAtRoute("Tables", new { id = current.Id }, current);
		}

		// DELETE tables/ProfilesId/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public Task DeleteProfilesId(string id)
		{
			return DeleteAsync(id);
		}
	}
}