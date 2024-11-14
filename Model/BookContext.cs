using Microsoft.EntityFrameworkCore;

namespace BookAPI.Model
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<DbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
    }
}
