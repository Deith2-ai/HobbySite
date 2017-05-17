using System.ComponentModel.DataAnnotations;
using Hobby.Web.App_GlobalResources;

namespace Hobby.Web.Parts.UserProfile.Models
{
    public class UserSettingsVM
    {
        [Display(Name = "FirstName", ResourceType = typeof(CommonStrings))]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string City { get; set; }

        public string Avatar { get; set; }
    }
}