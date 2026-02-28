using Microsoft.EntityFrameworkCore;
namespace ChatAppLive.Models
{
    public class AppDbContext: DbContext
    {
        private readonly DbContextOptions<AppDbContext> options;

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            this.options = options;
        }
        public DbSet<User> Users { get; set; }
    }
}
