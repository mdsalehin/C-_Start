using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExamples
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> ?Students { get; set; } // Table Mapping

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string to your database
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-0P39KA33\\SQLEXPRESS;Initial Catalog=CSharpB18;User ID=csharpb18;Password=123456;TrustServerCertificate=True;");
        }
    }
}
