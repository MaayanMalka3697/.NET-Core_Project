using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;

namespace Solid.Data.Entities
{
    public class DataContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DataContext()
        {
            //Teachers = new List<Teacher>();
            //Students = new List<Student>();
            //Courses = new List<Course>();

            //Teachers.Add(new Teacher(122, "nbn", "math"));
            //Students.Add(new Student(555, "fg", 88));
            //Courses.Add(new Course(555, "jk", 0.55));

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }


    }
}
