using Microsoft.EntityFrameworkCore;
using Task11PatternAndRelatedDataLoading.Models;
using Task12PatternAndRelatedDataLoading.Models;

namespace Task11PatternAndRelatedDataLoading.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<University> Universities { get; set; }
    }
}
