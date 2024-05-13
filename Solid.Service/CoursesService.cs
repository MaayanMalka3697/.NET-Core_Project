using Solid.Core.Entities;
using Solid.Core.Repositories; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class CoursesService
    {
        private readonly ICourseRepository _courseRepository;
        public CoursesService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public List<Course> GetAllCourses()
        {
            return _courseRepository.GetCourses();
        }



    }
}
