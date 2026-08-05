using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "Ahmed Ali", Age = 20, DepartmentName = "Computer Science" },
            new Student { Id = 2, Name = "Sara Mohamed", Age = 21, DepartmentName = "Information Systems" },
            new Student { Id = 3, Name = "Omar Hassan", Age = 19, DepartmentName = "Software Engineering" }
        };

        [HttpGet("welcome")]
        public IActionResult GetWelcomeMessage()
        {
            return Ok("Welcome to Student Management API");
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_students);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound($"Student with Id {id} was not found.");
            }

            return Ok(student);
        }

        [HttpGet("search")]
        public IActionResult SearchStudentsByName([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name)) {
                return Ok(new List<Student>());
            }

            var result = _students
            .Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            .ToList();

            return Ok(result);
        }

        [HttpGet("filter-by-age")]
        public IActionResult FilterStudentsByAge() {
            var result = _students
                .Where(s => s.Age >= 18 && s.Age <= 22)
                .OrderBy(s => s.Age)
                .ToList();

            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddStudent([FromBody] Student newStudent)
        {
            int newId = _students.Count > 0 ? _students.Max(s => s.Id) + 1 : 1;
            newStudent.Id = newId;

            _students.Add(newStudent);

            return CreatedAtAction(nameof(GetStudentById), new { id = newStudent.Id }, newStudent);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student updatedStudent) {
            var existingStudent = _students.FirstOrDefault(s => s.Id == id);

            if (existingStudent == null)
            {
                return NotFound($"Student with ID {id} was not found.");
            }

            existingStudent.Name = updatedStudent.Name;
            existingStudent.Age = updatedStudent.Age;
            existingStudent.DepartmentName = updatedStudent.DepartmentName;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id) {
            var student = _students.FirstOrDefault(s => s.Id == id);

            if (student == null) {
                return NotFound($"Student with ID {id} was not found.");
            }

            _students.Remove(student);

            return NoContent();
        }
    }
}