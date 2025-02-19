using Microsoft.EntityFrameworkCore;

namespace JoelMovieCollection.Models
{
    public class MoviesContext : DbContext // Define the MoviesContext class that inherits from DbContext 
        // liason between the database and the model
    {
        // Constructor for the MoviesContext class that takes DbContextOptions of type MoviesContext as a parameter
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }

        // Define a DbSet property named Movies that will be used to query and save instances of the Movie class
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>();
        }
    }
}
