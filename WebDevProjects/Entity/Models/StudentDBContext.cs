using Microsoft.EntityFrameworkCore;

namespace Entity.Models
{
    public class StudentDBContext:DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CodeFirstDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        public DbSet<Student> Students { get; set; }

    }
}
