using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Api.DTOs;

public class CreateStudentDto
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Range(18, 60)]
    public int Age { get; set; }

    public int DepartmentId { get; set; }
}