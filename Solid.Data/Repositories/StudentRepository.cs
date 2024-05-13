using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Data.Entities;

namespace Solid.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _dataContext;
        public StudentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Student> GetStudents()
        {
            return _dataContext.Students.Include(s => s.Courses).ToList();
        }

        public Student GetStudent(int id) {
        
           var student= _dataContext.Students.Find(id);
           return student;
        
        }

        public Student AddStudent(Student student)
        {
            _dataContext.Students.Add(student);
            _dataContext.SaveChanges();
            return student;
        }

        public Student UpdateStudent(Student student)
        {
            var s= GetStudent(student.Id);
            s.Id = student.Id;
            s.Name = student.Name;
            s.Courses = student.Courses;
         
            _dataContext.SaveChanges();
            return student;
        }
        public void DeleteStudent(int id)
        {
            var s=GetStudent(id);
            _dataContext.Students.Remove(s);
            _dataContext.SaveChanges();

        }










    }
}
