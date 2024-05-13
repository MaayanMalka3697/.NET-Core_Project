using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Service;


namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly StudentService _studentService;

        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }

        
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentService.GetAllStudents();
        }

      
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var s = _studentService.GetAllStudents().Find(x => x.Id == id);
            if (s == null)
                return NotFound();
            return s;
        }


        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _studentService.GetAllStudents().Add(student);
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            var s = _studentService.GetAllStudents().Find(x => x.Id == id);
            if (s == null)
                NotFound();
            else
            {
                s.Id = student.Id;
                s.Name = student.Name;
                s.Courses = student.Courses;

            }

        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var s = _studentService.GetAllStudents().Find(x => x.Id == id);
            //if (t == null)
            //    NotFound();
            //else
            s = null;

        }

    }
}
