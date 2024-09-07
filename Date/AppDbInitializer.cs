using eCommerceWebApp.Models;
using System;

namespace eCommerceWebApp.Date
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<clsAppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<clsCinema>()
                    {
                        new clsCinema()
                        {
                            Name = "Penn Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new clsCinema()
                        {
                            Name = "Movie House Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new clsCinema()
                        {
                            Name = "Great Likes Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new clsCinema()
                        {
                            Name = "State Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new clsCinema()
                        {
                            Name = "Nazareth Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<clsActor>()
                    {
                        new clsActor()
                        {
                            FullName = "Matt LeBlanc",
                            Bio = "Matthew Steven LeBlanc is an American actor. " +
                            "He garnered global recognition with his portrayal of Joey Tribbiani in the NBC sitcom Friends" +
                            " and in its spin-off series, Joey. For his work on Friends," +
                            " LeBlanc received three nominations at the Primetime Emmy Awards.",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new clsActor()
                        {
                            FullName = "Chris Tucker",
                            Bio = "Christopher Tucker is an American stand-up comedian and actor. " +
                            "Tucker made his debut in 1992 as a stand-up performer on the HBO comedy series Def Comedy Jam, " +
                            "where he frequently appeared on the show during the 1990s",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new clsActor()
                        {
                            FullName = "Angelina Jolie",
                            Bio = "Angelina Jolie is an American actress, filmmaker, and humanitarian. " +
                            "The recipient of numerous accolades, including an Academy Award, " +
                            "a Tony Award and three Golden Globe Awards, she has been named Hollywood's highest-paid actress multiple times.",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new clsActor()
                        {
                            FullName = "Jim Carrey",
                            Bio = "Jim Carrey, Canadian-born and a U.S. citizen since 2004, " +
                            "is an actor and producer famous for his rubbery body movements and flexible facial expressions.",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new clsActor()
                        {
                            FullName = "Will Smith",
                            Bio = "Willard Carroll Smith II is an American actor, rapper and film producer. " +
                            "He has received multiple accolades, including an Academy Award, a Golden Globe Award, " +
                            "a BAFTA Award, and four Grammy Awards. As of 2024, his films have grossed over $9.3 billion globally, " +
                            "making him one of Hollywood's most bankable stars.",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<clsProducer>()
                    {
                        new clsProducer()
                        {
                            FullName = "Frank Marshall",
                            Bio = "Frank Wilton Marshall is an American film producer and director. " +
                            "He often collaborates with his wife, film producer Kathleen Kennedy, " +
                            "with whom he founded the production company Amblin Entertainment, along with Steven Spielberg.",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new clsProducer()
                        {
                            FullName = "Steven Spielberg",
                            Bio = "Steven Allan Spielberg is an American filmmaker. " +
                            "A major figure of the New Hollywood era and pioneer of the modern blockbuster, " +
                            "he is the most commercially successful director in film history.",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new clsProducer()
                        {
                            FullName = "Quentin Tarantino",
                            Bio = "Quentin Jerome Tarantino is an American filmmaker. " +
                            "His films are characterized by stylized violence, extended dialogue often with profanity, " +
                            "and references to popular culture.",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new clsProducer()
                        {
                            FullName = "Spike Lee",
                            Bio = "Shelton Jackson \"Spike\" Lee is an American film director, producer, screenwriter, actor, and author. " +
                            "His work has continually explored race relations, issues within the black community, " +
                            "the role of media in contemporary life, urban crime and poverty, and other political issues.",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new clsProducer()
                        {
                            FullName = "Jerry Bruckheimer",
                            Bio = "Jerome Leon Bruckheimer is an American film and television producer. " +
                            "He has been active in the genres of action, drama, comedy, fantasy, horror and science fiction. " +
                            "After working in advertising out of college, Bruckheimer moved into film production in the 1970s.",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<clsMovie>()
                    {
                        new clsMovie()
                        {
                            Name = "Life",
                            Description = "As astronauts discover the first evidence of extra-terrestrial life on Mars, " +
                            "they begin realising that the life form is extremely intelligent and hostile.",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 34,
                            ProducerId = 23,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new clsMovie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "Andy Dufresne, a successful banker, is arrested for the murders of his wife and her lover, " +
                            "and is sentenced to life imprisonment at the Shawshank prison. He becomes the most unconventional prisoner.",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 32,
                            ProducerId = 21,
                            MovieCategory = MovieCategory.Action
                        },
                        new clsMovie()
                        {
                            Name = "Ghost",
                            Description = "Ghost is a Swedish rock band known for its distinctive blend of theatricality, heavy metal, and arena rock. " +
                            "Formed in Linköping in 2006, the band first gained attention with their 2010 three-track demo, " +
                            "followed by the 7-inch vinyl \"Elizabeth\" and their debut album, Opus Eponymous.",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 35,
                            ProducerId = 24,
                            MovieCategory = MovieCategory.Horror
                        },
                        new clsMovie()
                        {
                            Name = "Race",
                            Description = "African-American athlete Jesse Owens faces many difficulties throughout his journey while participating in the 1936 Berlin Olympics.",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 32,
                            ProducerId = 22,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new clsMovie()
                        {
                            Name = "Scoob",
                            Description = "Shaggy and Scooby learn that Dick Dastardly, a villain, is out to capture Scooby. " +
                            "With the help of masked superhero Blue Falcon, the Mystery Inc gang sets out to thwart the supercriminal's evil plans.",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 32,
                            ProducerId = 23,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new clsMovie()
                        {
                            Name = "Cold Soles",
                            Description = "Paul, an actor, struggles while preparing for the role of a Russian poet in a play. " +
                            "With the help of a company, he exchanges his soul with that of the poet, but soon things spiral out of control.",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 32,
                            ProducerId = 25,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<clsActor_Movie>()
                    {
                        new clsActor_Movie()
                        {
                            ActorId = 21,
                            MovieId = 11
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 23,
                            MovieId = 11
                        },

                         new clsActor_Movie()
                        {
                            ActorId = 21,
                            MovieId = 12
                        },
                         new clsActor_Movie()
                        {
                            ActorId = 24,
                            MovieId = 12
                        },

                        new clsActor_Movie()
                        {
                            ActorId = 21,
                            MovieId = 13
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 22,
                            MovieId = 13
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 25,
                            MovieId = 13
                        },


                        new clsActor_Movie()
                        {
                            ActorId = 22,
                            MovieId = 14
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 23,
                            MovieId = 14
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 24,
                            MovieId = 14
                        },


                        new clsActor_Movie()
                        {
                            ActorId = 22,
                            MovieId = 15
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 23,
                            MovieId = 15
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 24,
                            MovieId = 15
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 25,
                            MovieId = 15
                        },


                        new clsActor_Movie()
                        {
                            ActorId = 23,
                            MovieId = 16
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 24,
                            MovieId = 16
                        },
                        new clsActor_Movie()
                        {
                            ActorId = 25,
                            MovieId = 16
                        },
                    });
                    context.SaveChanges();
                }

                //context.SaveChanges();

            }

        }

    }
}
