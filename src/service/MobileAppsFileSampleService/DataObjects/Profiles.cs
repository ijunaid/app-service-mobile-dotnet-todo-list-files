using Microsoft.Azure.Mobile.Server;
namespace MobileAppsFileSampleService.DataObjects
{
	public class Profiles : EntityData
	{

		public new string Id { get; set; }
		public string UserId { get; set; }
		public string Name { get; set; }
		public int BusinessId { get; set; }
		public string Logo { get; set; }
		public string Overwiew { get; set; }
		public int CountryId { get; set; }
		public string Website { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string Hotline { get; set; }
		public string Mobile { get; set; }

		public string WhatsApp { get; set; }
		public string Facebook { get; set; }
		public string Twitter { get; set; }
		public string GooglePlus { get; set; }
		public string Instagram { get; set; }
		public string Linkedin { get; set; }

	}
}
