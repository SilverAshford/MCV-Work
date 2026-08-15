using StudentManagement.Api.DTOs;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Services;

public interface IDepartmentService
{
    List<Department> GetAllDepartments();
    Department? GetDepartmentById(int id);
    Department? AddDepartment(CreateDepartmentDto dto);
    bool UpdateDepartment(int id, UpdateDepartmentDto dto);
    bool DeleteDepartment(int id);
    List<DepartmentStatisticsDto> GetDepartmentStatistics();
    HighestLowestDepartmentDto GetHighestAndLowestDepartment();
}