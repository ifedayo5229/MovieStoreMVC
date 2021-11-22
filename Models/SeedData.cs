using Microsoft.EntityFrameworkCore;

namespace movieAPP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = " Harry Met Sally",
                        Director ="Romantic Comedy",
                        Genres ="drama",
                        YearReleased = "2021"
                        
                    },

                    new Movie
                    {
                       Title = "When Harry Met ",
                        Director ="Romantic Comedy",
                        Genres ="drama",
                        YearReleased = "2016"
                    },

                    new Movie
                    {
                        Title = "When Harry Meuu Sally",
                        Director ="Romantiuiu Comedy",
                        Genres ="drama",
                        YearReleased = "2092",
                    },

                    new Movie
                    {
                       Title = "When Harruyuu Met Sally",
                        Director ="Romantic Comedy",
                        Genres ="drama",
                        YearReleased = "2036"
                    }
                );
                context.SaveChanges();
        }   }
    }
}