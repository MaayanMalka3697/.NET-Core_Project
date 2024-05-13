using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class TeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
           _teacherRepository = teacherRepository;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetTeachers();

        }

    }
}
