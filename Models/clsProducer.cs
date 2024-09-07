using System.ComponentModel.DataAnnotations;
using eCommerceWebApp.Date;

namespace eCommerceWebApp.Models
{
    public class clsProducer:clsPerson
    {

        [Key]
        public int Id { get; set; }

        //Relationships

        public List<clsMovie> Movies { get; set; }

    }
}
