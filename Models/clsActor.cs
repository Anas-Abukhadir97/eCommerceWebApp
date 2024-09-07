using System.ComponentModel.DataAnnotations;
using eCommerceWebApp.Date;

namespace eCommerceWebApp.Models
{
    public class clsActor :clsPerson
    {

        [Key]
        public int Id { get; set; }

        //Relationships

        public List<clsActor_Movie> Actor_Movie { get; set; }


    }
}
