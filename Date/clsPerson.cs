using System.ComponentModel.DataAnnotations;

namespace eCommerceWebApp.Date
{
    public class clsPerson
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

		[Display(Name = "Bio")]
		public string Bio { get; set; }

		[Display(Name = "Profile Picture")]
		public string ProfilePictureURL { get; set; }
        public int Age { get; set; }

    }
}
