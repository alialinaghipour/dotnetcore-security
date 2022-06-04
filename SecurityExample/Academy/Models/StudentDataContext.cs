using Microsoft.EntityFrameworkCore;

namespace Academy.Models
{
    public class StudentDataContext:DbContext
    {
        public StudentDataContext(DbContextOptions<StudentDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<CourseGrade> Grades { get; set; }

    }
}
