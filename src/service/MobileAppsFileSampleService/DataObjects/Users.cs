using Microsoft.Azure.Mobile.Server;
using System;
namespace MobileAppsFileSampleService
{
	public class Users : EntityData
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Gender { get; set; }
		public string Mobile { get; set; }
		public string Password { get; set; }
		public bool HasProfile { get; set; }
		public int MobileKey { get; set; }
		public int CountryId { get; set; }
		public DateTime BirthDay { get; set; }
		public DateTime LastLogin { get; set; }

		[Newtonsoft.Json.JsonIgnore]
		public string BirthDayDisplay { get { return BirthDay.ToString("d"); } }
	}
}
