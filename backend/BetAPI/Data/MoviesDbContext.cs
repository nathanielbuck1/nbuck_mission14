using Microsoft.EntityFrameworkCore;

namespace BetAPI.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options) { }
        public DbSet<JMovies> Movies { get; set; }
    }
}
