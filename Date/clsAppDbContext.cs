using eCommerceWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceWebApp.Date
{
    public class clsAppDbContext:DbContext
    {
        public clsAppDbContext(DbContextOptions<clsAppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<clsActor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId,
            });

            modelBuilder.Entity<clsActor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movie).HasForeignKey(am => am.MovieId);

            modelBuilder.Entity<clsActor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movie).HasForeignKey(am => am.ActorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<clsActor> Actors { get; set; }
        public DbSet<clsMovie> Movies { get; set; }
        public DbSet<clsProducer> Producers { get; set; }
        public DbSet<clsCinema> Cinemas { get; set; }
        public DbSet<clsActor_Movie> Actors_Movies { get; set; }


    }
}
