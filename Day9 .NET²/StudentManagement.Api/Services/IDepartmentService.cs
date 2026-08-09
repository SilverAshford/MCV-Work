using StudentManagement.Api.DTOs;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Services;

public interface IDepartmentService
{
    List<Department> GetAllDepartments();
    Department? GetDepartmentById(int id);
    Department AddDepartment(Department department);
    bool UpdateDepartment(int id, Department department);
    bool DeleteDepartment(int id);
    List<DepartmentStatisticsDto> GetDepartmentStatistics();
    HighestLowestDepartmentDto GetHighestAndLowestDepartment();
}