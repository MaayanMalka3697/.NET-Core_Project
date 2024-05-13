using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Service;


namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : Controller
    {
        private readonly TeacherService _teacherService;

        public TeachersController(TeacherService teacherService)
        {
            _teacherService = teacherService;
        }


        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return _teacherService.GetAllTeachers();
        }


      
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int id)
        {
            var t = _teacherService.GetAllTeachers().Find(x => x.Id == id);
            if (t == null)
                return NotFound();
            return t;
        }

    
        [HttpPost]
        public void Post([FromBody] Teacher teacher)
        {
            _teacherService.GetAllTeachers().Add(teacher);
        }

       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Teacher teacher)
        {
            var t = _teacherService.GetAllTeachers().Find(x => x.Id == id);
            if (t == null)
                NotFound();
            else
            {
                t.Id = teacher.Id;
                t.Name = teacher.Name;
                t.CoursesTeaching = teacher.CoursesTeaching;

            }

        }

        // DELETE api/<TeachersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var t = _teacherService.GetAllTeachers().Find(x => x.Id == id);
            //if (t == null)
            //    NotFound();
            //else
            t = null;

        }

    }
}
