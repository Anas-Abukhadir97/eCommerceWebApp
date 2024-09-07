namespace eCommerceWebApp.Models
{
    public class clsActor_Movie
    {
        public int MovieId { get; set; }
        public clsMovie Movie { get; set; }

        public int ActorId { get; set; }
        public clsActor Actor { get; set; }

    }
}
