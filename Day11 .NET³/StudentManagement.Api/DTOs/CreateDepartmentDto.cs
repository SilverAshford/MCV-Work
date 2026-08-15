using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Api.DTOs;

public class CreateDepartmentDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
}