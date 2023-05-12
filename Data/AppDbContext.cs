using Microsoft.EntityFrameworkCore;

namespace Librozone.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.Publisher> Publishers { get; set; }
    }
}
