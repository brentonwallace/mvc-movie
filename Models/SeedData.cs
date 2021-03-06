using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using mvc_movie.Data;


namespace mvc_movie.Models
{


    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
serviceProvider.GetRequiredService<
    DbContextOptions<MvcMovieContext>>()))
            {

                // Look for movies ->

                if (context.Movie.Any())
                {
                    return;  //DB is seeded...
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99m
                    },

                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99m
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 8.99m                    
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99m
                    },

                    new Movie
                    {
                        Title = "Kill Bill",
                        ReleaseDate = DateTime.Parse("2003-10-16"),
                        Genre = "Action",
                        Price = 8.9m
                    },

                    new Movie
                    {
                        Title = "Prometheus",
                        ReleaseDate = DateTime.Parse("2012-7-6"),
                        Genre = "Sci-Fi",
                        Price = 8.99m
                    },

                    new Movie
                    {
                        Title = "Dr. No",
                        ReleaseDate = DateTime.Parse("1963-7-4"),
                        Genre = "Action",
                        Price = 9.99m
                    }




                    );


                context.SaveChanges();
            }
        }
    }
}
