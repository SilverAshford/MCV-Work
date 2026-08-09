using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.DTOs;
using StudentManagement.Api.Services;

namespace StudentManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet("welcome")]
    public IActionResult GetWelcomeMessage()
    {
        return Ok("Welcome to Student Management API");
    }

    [HttpGet]
    public IActionResult GetAllStudents()
    {
        return Ok(_studentService.GetAllStudents());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetStudentById(int id)
    {
        var student = _studentService.GetStudentById(id);

        if (student == null)
        {
            return NotFound($"Student with Id {id} was not found.");
        }

        return Ok(student);
    }

    [HttpGet("search")]
    public IActionResult SearchStudentsByName([FromQuery] string name)
    {
        var result = _studentService.SearchStudentsByName(name);

        return Ok(result);
    }

    [HttpGet("filter-by-age")]
    public IActionResult FilterStudentsByAge()
    {
        var result = _studentService.FilterStudentsByAge();

        return Ok(result);
    }

    [HttpPost]
    public IActionResult AddStudent([FromBody] CreateStudentDto newStudent)
    {
        var student = _studentService.AddStudent(newStudent);

        if (student == null)
        {
            return BadRequest($"Department with Id {newStudent.DepartmentId} does not exist.");
        }

        return CreatedAtAction(
            nameof(GetStudentById),
            new { id = student.Id },
            student
        );
    }

    [HttpPut("{id}")]
    public IActionResult UpdateStudent(
        int id,
        [FromBody] UpdateStudentDto updatedStudent)
    {
        var result = _studentService.UpdateStudent(id, updatedStudent);

        if (result == "StudentNotFound")
        {
            return NotFound($"Student with ID {id} was not found.");
        }

        if (result == "DepartmentNotFound")
        {
            return BadRequest(
                $"Department with ID {updatedStudent.DepartmentId} does not exist."
            );
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStudent(int id)
    {
        var result = _studentService.DeleteStudent(id);

        if (!result)
        {
            return NotFound($"Student with ID {id} was not found.");
        }

        return NoContent();
    }
}
