using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.Models;
using StudentManagement.Api.Services;

namespace StudentManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly IDepartmentService _departmentService;
    private readonly IStudentService _studentService;

    public DepartmentsController(
        IDepartmentService departmentService,
        IStudentService studentService)
    {
        _departmentService = departmentService;
        _studentService = studentService;
    }

    [HttpGet]
    public IActionResult GetAllDepartments()
    {
        return Ok(_departmentService.GetAllDepartments());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetDepartmentById(int id)
    {
        var department = _departmentService.GetDepartmentById(id);

        if (department == null)
        {
            return NotFound($"Department with Id {id} was not found.");
        }

        return Ok(department);
    }

    [HttpPost]
    public IActionResult AddDepartment([FromBody] Department department)
    {
        var newDepartment = _departmentService.AddDepartment(department);

        return CreatedAtAction(
            nameof(GetDepartmentById),
            new { id = newDepartment.Id },
            newDepartment
        );
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateDepartment(
        int id,
        [FromBody] Department updatedDepartment)
    {
        var result = _departmentService.UpdateDepartment(id, updatedDepartment);

        if (!result)
        {
            return NotFound($"Department with Id {id} was not found.");
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteDepartment(int id)
    {
        var result = _departmentService.DeleteDepartment(id);

        if (!result)
        {
            return NotFound($"Department with Id {id} was not found.");
        }

        return NoContent();
    }

    [HttpGet("highest-lowest")]
    public IActionResult GetHighestAndLowestDepartment()
    {
        return Ok(_departmentService.GetHighestAndLowestDepartment());
    }
}