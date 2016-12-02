using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Files;
using Microsoft.Azure.Mobile.Server.Files.Controllers;
using MobileAppsFileSampleService.DataObjects;

namespace MobileAppsFileSampleService.Controllers
{
	public class ProfilesIdStorageController : StorageController<ProfilesId>
	{
		[HttpPost]
		[Route("tables/ProfilesId/{id}/StorageToken")]
		public async Task<HttpResponseMessage> PostStorageTokenRequest(string id, StorageTokenRequest value)
		{
			StorageToken token = await GetStorageTokenAsync(id, value);

			return Request.CreateResponse(token);
		}

		// Get the files associated with this record
		[HttpGet]
		[Route("tables/ProfilesId/{id}/MobileServiceFiles")]
		public async Task<HttpResponseMessage> GetFiles(string id)
		{
			IEnumerable<MobileServiceFile> files = await GetRecordFilesAsync(id);

			return Request.CreateResponse(files);
		}

		[HttpDelete]
		[Route("tables/ProfilesId/{id}/MobileServiceFiles/{name}")]
		public Task Delete(string id, string name)
		{
			return base.DeleteFileAsync(id, name);
		}
	}
}
