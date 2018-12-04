using Microsoft.EntityFrameworkCore;

namespace Shop.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Opinion> Opinions { get; set; }
    }
}
