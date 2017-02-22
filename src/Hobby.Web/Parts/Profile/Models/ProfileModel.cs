using System.ComponentModel.DataAnnotations;

namespace Hobby.Web.Parts.Profile.Models
{
    public class ProfileModel
    {
        [Required]
        public decimal Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Email { get; set; }

        public int Age { get; set; }

        public string ActivityName { get; set; }

        public string City { get; set; }
    }
}