using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Data.Entities;
namespace Solid.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _dataContext;

        public CourseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Course> GetCourses()
        {
            return _dataContext.Courses.Include(c => c.Teacher).Include(c => c.Students).ToList();
        }

        public Course GetCourse(int id)
        {
            var course = _dataContext.Courses.Find(id);
            return course;
        }
        public Course AddCourse(Course course)
        {
            _dataContext.Courses.Add(course);
            _dataContext.SaveChanges();
            return course;
        }

        public Course UpdateCourse(Course course)
        {
            var c = GetCourse(course.Id);
            c.Id = course.Id;
            c.Name = course.Name;
            c.Price = course.Price;
            c.Students = course.Students;
            c.Teacher = course.Teacher;

            _dataContext.SaveChanges();
            return course;
        }

        public void DeleteCourse(int id)
        {
            var course = GetCourse(id);
            if (course != null)
            {
                _dataContext.Courses.Remove(course);
                _dataContext.SaveChanges();
            }

        }










    }
}
