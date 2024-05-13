using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Service;



namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : Controller
    {
        private readonly CoursesService _coursesService;

        public CoursesController(CoursesService coursesService)
        {
            _coursesService = coursesService;
        }


        

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _coursesService.GetAllCourses();
        }

       
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            var c = _coursesService.GetAllCourses().Find(x => x.Id == id);
            if (c == null)
                return NotFound();
            return c;
        }

       
        [HttpPost]
        public void Post([FromBody] Course course)
        {
            _coursesService.GetAllCourses().Add(course);
        }

      
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course course)
        {
            var c = _coursesService.GetAllCourses().Find(x => x.Id == id);
            if (c == null)
                NotFound();
            else
            {
                c.Id = course.Id;
                c.Name = course.Name;
                c.Price = course.Price;

            }

        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var c = _coursesService.GetAllCourses().Find(x => x.Id == id);
            //if (t == null)
            //    NotFound();
            //else
            c = null;
            //or
            //c.Price = 0;
            //c.Name = "";
            //c.Id = -1;
            //To ask the teacher...!*******************************************


        }
    }
}
