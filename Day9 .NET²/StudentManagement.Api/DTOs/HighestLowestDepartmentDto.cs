namespace StudentManagement.Api.DTOs;

public class HighestLowestDepartmentDto
{
    public DepartmentStatisticsDto? Highest { get; set; }
    public DepartmentStatisticsDto? Lowest { get; set; }
}