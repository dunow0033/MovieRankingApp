using Microsoft.EntityFrameworkCore;

namespace MovieRanking.Models
{
    public class MovieDBContext:DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options) 
        {
            
        }

        public DbSet<ItemModel> Items { get; set; }
    }
}
