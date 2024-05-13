using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class TeacherRepository: ITeacherRepository
    {
        private readonly DataContext _dataContext;

        public TeacherRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Teacher> GetTeachers()
        {
            return _dataContext.Teachers.Include(t => t.CoursesTeaching).ToList();
        }

        public Teacher GetTeacher(int id) 
        {
            var teacher= _dataContext.Teachers.Find(id);
            return teacher;
        }

        public Teacher AddTeacher(Teacher teacher)
        {
            _dataContext.Teachers.Add(teacher);
            _dataContext.SaveChanges();
            return teacher;
        }
        public Teacher UpdateTeacher(Teacher teacher)
        {
            var t= GetTeacher(teacher.Id);
            t.Id = teacher.Id;
            t.Name = teacher.Name;
            t.CoursesTeaching = teacher.CoursesTeaching;

            _dataContext.SaveChanges();
            return teacher;
        }

        public void DeleteTeacher(int id) 
        {
            var t=GetTeacher(id);
            _dataContext.Teachers.Remove(t);
            _dataContext.SaveChanges();


        }



    }
}
