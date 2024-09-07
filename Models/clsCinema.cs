using System.ComponentModel.DataAnnotations;

namespace eCommerceWebApp.Models
{
    public class clsCinema
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }

        //Relationships

        public List<clsMovie> Movies { get; set; }

    }
}
