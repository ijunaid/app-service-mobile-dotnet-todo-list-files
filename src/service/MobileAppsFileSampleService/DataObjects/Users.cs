using Microsoft.Azure.Mobile.Server;
using System;
namespace MobileAppsFileSampleService.DataObjects
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
		public DateTimeOffset? BirthDay { get; set; }
		public DateTimeOffset? LastLogin { get; set; }
	}
}
