namespace StudentManagement.Api.DTOs;

public class UpdateStudentDto {
    public required string Name { get; set; }
    public int Age { get; set; }
    public required int DepartmentId { get; set; }
}