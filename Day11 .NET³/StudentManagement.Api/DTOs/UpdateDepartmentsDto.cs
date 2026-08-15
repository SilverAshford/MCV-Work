using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Api.DTOs;

public class UpdateDepartmentDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
}