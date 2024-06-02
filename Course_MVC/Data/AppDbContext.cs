using Course_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Course_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }
        public DbSet<CategoryImage> CategoryImages { get; set; }
    }
}
