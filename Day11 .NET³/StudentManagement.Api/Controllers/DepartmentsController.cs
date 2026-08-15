using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.Models;
using StudentManagement.Api.Services;
using StudentManagement.Api.DTOs;

namespace StudentManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly IDepartmentService _departmentService;

    public DepartmentsController(
        IDepartmentService departmentService,
        IStudentService studentService)
    {
        _departmentService = departmentService;
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
    public IActionResult AddDepartment([FromBody] CreateDepartmentDto dto)
    {
        var newDepartment = _departmentService.AddDepartment(dto);

        if (newDepartment == null)
        {
            return BadRequest("Department name already exists.");
        }

        return CreatedAtAction(
            nameof(GetDepartmentById),
            new { id = newDepartment.Id },
            newDepartment
        );
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateDepartment(
        int id,
        [FromBody] UpdateDepartmentDto dto)
    {
        var result = _departmentService.UpdateDepartment(id, dto);

        if (!result)
        {
            return NotFound(
                $"Department with Id {id} was not found or the name already exists."
            );
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

    [HttpGet("statistics")]
    public IActionResult GetDepartmentStatistics()
    {
        return Ok(_departmentService.GetDepartmentStatistics());
    }
}