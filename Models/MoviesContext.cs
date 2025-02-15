using Microsoft.EntityFrameworkCore;

namespace JoelMovieCollection.Models
{
    public class MoviesContext : DbContext // Define the MoviesContext class that inherits from DbContext
    {
        // Constructor for the MoviesContext class that takes DbContextOptions of type MoviesContext as a parameter
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }

        // Define a DbSet property named Movies that will be used to query and save instances of the Movie class
        public DbSet<Movie> Movies { get; set; }
    }
}
