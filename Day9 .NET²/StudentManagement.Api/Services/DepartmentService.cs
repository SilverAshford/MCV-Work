using StudentManagement.Api.Models;
using StudentManagement.Api.DTOs;

namespace StudentManagement.Api.Services;

public class DepartmentService : IDepartmentService
{

    private readonly IStudentService _studentService;

    public DepartmentService(IStudentService studentService)
    {
        _studentService = studentService;
    }
    private static List<Department> _departments = new List<Department>
    {
        new Department { Id = 1, Name = "IT" },
        new Department { Id = 2, Name = "HR" },
        new Department { Id = 3, Name = "Finance" },
        new Department { Id = 4, Name = "Sales" }
    };

    public List<Department> GetAllDepartments()
    {
        return _departments;
    }

    public Department? GetDepartmentById(int id)
    {
        return _departments.FirstOrDefault(d => d.Id == id);
    }

    public Department AddDepartment(Department department)
    {
        int newId = _departments.Count > 0
            ? _departments.Max(d => d.Id) + 1
            : 1;

        department.Id = newId;
        _departments.Add(department);

        return department;
    }

    public bool UpdateDepartment(int id, Department updatedDepartment)
    {
        var department = _departments.FirstOrDefault(d => d.Id == id);

        if (department == null)
        {
            return false;
        }

        department.Name = updatedDepartment.Name;

        return true;
    }

    public bool DeleteDepartment(int id)
    {
        var department = _departments.FirstOrDefault(d => d.Id == id);

        if (department == null)
        {
            return false;
        }

        _departments.Remove(department);

        return true;
    }

    public List<DepartmentStatisticsDto> GetDepartmentStatistics()
    {
        return _departments
            .Select(d =>
            {
                var students = _studentService
                    .GetStudentsForStatistics()
                    .Where(s => s.DepartmentId == d.Id)
                    .ToList();

                return new DepartmentStatisticsDto
                {
                    DepartmentName = d.Name,
                    StudentCount = students.Count,
                    AverageAge = students.Count > 0 ? students.Average(s => s.Age) : 0,
                    OldestAge = students.Count > 0 ? students.Max(s => s.Age) : 0,
                    YoungestAge = students.Count > 0 ? students.Min(s => s.Age) : 0
                };
            })
            .ToList();
    }

    public HighestLowestDepartmentDto GetHighestAndLowestDepartment()
    {
        var statistics = GetDepartmentStatistics();

        return new HighestLowestDepartmentDto
        {
            Highest = statistics
                .OrderByDescending(d => d.StudentCount)
                .FirstOrDefault(),

            Lowest = statistics
                .OrderBy(d => d.StudentCount)
                .FirstOrDefault()
        };
    }
}