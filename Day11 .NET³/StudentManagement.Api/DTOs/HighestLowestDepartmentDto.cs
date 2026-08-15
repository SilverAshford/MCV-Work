namespace StudentManagement.Api.DTOs;

public class HighestLowestDepartmentDto
{
    public List<DepartmentStatisticsDto> Highest { get; set; } = new();
    public List<DepartmentStatisticsDto> Lowest { get; set; } = new();
}