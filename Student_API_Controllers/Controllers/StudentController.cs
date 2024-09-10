using Microsoft.AspNetCore.Mvc;
using Student_API_Controllers.Models;

namespace Student_API_Controllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>()
        {
        new Student { Id = 1, FirstName = "Paul", LastName = "Ochon", Birthdate = new DateTime(1950, 12, 1) },
        new Student { Id = 2, FirstName = "Daisy", LastName = "Drathey", Birthdate = new DateTime(1970, 12, 1) },
        new Student { Id = 3, FirstName = "Elie", LastName = "Coptaire", Birthdate = new DateTime(1980, 12, 1) }
        };



        [HttpGet(Name = "GetStudentsList")]
        public IEnumerable<Student> Get()
        {
            return _students;
        }

        [HttpPost(Name = "PostStudent")]
        public IActionResult Post([FromBody] Student student)
        {
            if (student == null) return BadRequest("Data is null");

            student.Id = _students.Max(s => s.Id) + 1;
            _students.Add(student);

            return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            foreach(var student in _students)
            {
                if(student.Id == id)
                    return Ok(student);
            }
            return NotFound();
        }
    }
}
