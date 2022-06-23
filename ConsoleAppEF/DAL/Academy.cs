using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppEF.DAL;

namespace ConsoleAppEF.DAL
{
    public class Academy : DbContext
    {
        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=CoreNet6Test;Integrated Security=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var c1 = new Course
            {
                Id = 1,
                Name = "C1"
            };
            var c2 = new Course
            {
                Id = 2,
                Name = "C2"
            };
            var c3 = new Course
            {
                Id = 3,
                Name = "C3"
            };
            var s1 = new Student
            {
                Id = 1,
                Name = "S1",
                CourseId = 1,
                Score = 91
            };

            var s2 = new Student
            {
                Id = 2,
                Name = "S2",
                CourseId = 1,
                Score = 99
            };

            var s3 = new Student
            {
                Id = 3,
                Name = "S3",
                CourseId = 1,
                Score = 90
            };

            var s4 = new Student
            {
                Id = 4,
                Name = "S4",
                CourseId = 2,
                Score = 90
            };
            var s5 = new Student
            {
                Id = 5,
                Name = "S5",
                CourseId = 2,
                Score = 100
            };
            modelBuilder.Entity<Course>().HasData(c1, c2, c3);
            modelBuilder.Entity<Student>().HasData(s1, s2, s3, s4, s5);
        }
    }
}
