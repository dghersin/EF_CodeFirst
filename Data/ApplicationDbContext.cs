using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Students
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "Marko Markovic", DateOfBirth = new DateTime(2000, 1, 31), Height = 1.80m, Weight = 75.5f },
                new Student { StudentId = 2, StudentName = "Pero Peric", DateOfBirth = new DateTime(1999, 12, 12), Height = 1.70m, Weight = 65.3f }
            );

            // Seed data for Grades
            modelBuilder.Entity<Grade>().HasData(
                new Grade { GradeId = 1, GradeName = "Math", Section = "A", StudentId = 1 },
                new Grade { GradeId = 2, GradeName = "Science", Section = "B", StudentId = 1 },
                new Grade { GradeId = 3, GradeName = "History", Section = "A", StudentId = 1 },
                new Grade { GradeId = 4, GradeName = "Math", Section = "A", StudentId = 2 },
                new Grade { GradeId = 5, GradeName = "Science", Section = "B", StudentId = 2 },
                new Grade { GradeId = 6, GradeName = "History", Section = "A", StudentId = 2 },
                new Grade { GradeId = 7, GradeName = "Physics", Section = "C", StudentId = 2 }
            );
        }
    }
}
