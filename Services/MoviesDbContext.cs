using Microsoft.EntityFrameworkCore;
using MoviesApi.Entities;

namespace MoviesApi.Services
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MoviesDbContext(
            DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}