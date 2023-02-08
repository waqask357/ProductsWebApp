using Microsoft.EntityFrameworkCore;

namespace ProductsWebApp.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> BookTable { get; set; }
    }
}
