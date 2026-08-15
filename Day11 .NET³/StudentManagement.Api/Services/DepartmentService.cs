using StudentManagement.Api.Models;
using StudentManagement.Api.DTOs;
using StudentManagement.Api.Data;

namespace StudentManagement.Api.Services;

public class DepartmentService : IDepartmentService
{
    private readonly AppDbContext _context;

    public DepartmentService(AppDbContext context)
    {
        _context = context;
    }

    public List<Department> GetAllDepartments()
    {
        return _context.Departments.ToList();
    }

    public Department? GetDepartmentById(int id)
    {
        return _context.Departments.FirstOrDefault(d => d.Id == id);
    }

    public Department? AddDepartment(CreateDepartmentDto dto)
    {
        var nameExists = _context.Departments
            .Any(d => d.Name == dto.Name);

        if (nameExists)
        {
            return null;
        }

        var department = new Department
        {
            Name = dto.Name
        };

        _context.Departments.Add(department);

        _context.SaveChanges();

        return department;
    }

    public bool UpdateDepartment(int id, UpdateDepartmentDto dto)
    {
        var department = _context.Departments
            .FirstOrDefault(d => d.Id == id);

        if (department == null)
        {
            return false;
        }

        var nameExists = _context.Departments
            .Any(d => d.Id != id && d.Name == dto.Name);

        if (nameExists)
        {
            return false;
        }

        department.Name = dto.Name;

        _context.SaveChanges();

        return true;
    }

    public bool DeleteDepartment(int id)
    {
        var department = _context.Departments.FirstOrDefault(d => d.Id == id);

        if (department == null)
        {
            return false;
        }

        _context.Departments.Remove(department);

        _context.SaveChanges();

        return true;
    }

    public List<DepartmentStatisticsDto> GetDepartmentStatistics()
    {
        var departments = _context.Departments.ToList();
        var students = _context.Students.ToList();

        return departments
            .Select(d =>
            {
                var departmentStudents = students
                    .Where(s => s.DepartmentId == d.Id)
                    .ToList();

                return new DepartmentStatisticsDto
                {
                    DepartmentName = d.Name,
                    StudentCount = departmentStudents.Count,
                    AverageAge = departmentStudents.Count > 0
                        ? departmentStudents.Average(s => s.Age)
                        : 0,
                    OldestAge = departmentStudents.Count > 0
                        ? departmentStudents.Max(s => s.Age)
                        : 0,
                    YoungestAge = departmentStudents.Count > 0
                        ? departmentStudents.Min(s => s.Age)
                        : 0
                };
            })
            .ToList();
    }

    public HighestLowestDepartmentDto GetHighestAndLowestDepartment()
    {
        var statistics = GetDepartmentStatistics();

        if (statistics.Count == 0)
        {
            return new HighestLowestDepartmentDto();
        }

        var highestCount = statistics.Max(d => d.StudentCount);
        var lowestCount = statistics.Min(d => d.StudentCount);

        return new HighestLowestDepartmentDto
        {
            Highest = statistics
                .Where(d => d.StudentCount == highestCount)
                .ToList(),

            Lowest = statistics
                .Where(d => d.StudentCount == lowestCount)
                .ToList()
        };
    }
}