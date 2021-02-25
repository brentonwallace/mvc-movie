using Microsoft.EntityFrameworkCore;
using mvc_movie.Models;

namespace mvc_movie.Data
{
    public class MvcMovieContext : DbContext
    {

        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {

        }


        public DbSet<Movie> Movie { get; set; }
    }
}
