using Microsoft.Azure.Mobile.Server;
namespace MobileAppsFileSampleService.DataObjects
{
	public class ProfilesId : EntityData
	{
		public string ProfileId { get; set; }
		public string UserId { get; set; }
		public string ProfileKey { get; set; }
	}
}
