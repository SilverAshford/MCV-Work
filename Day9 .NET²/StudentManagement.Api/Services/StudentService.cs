using StudentManagement.Api.DTOs;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Services;

public class StudentService : IStudentService
{
    private static List<Student> _students = new List<Student> {
        new Student { Id = 1, Name = "Ahmed Ali", Age = 20, DepartmentId = 1 },
        new Student { Id = 2, Name = "Sara Mohamed", Age = 21, DepartmentId = 2 },
        new Student { Id = 3, Name = "Omar Hassan", Age = 19, DepartmentId = 3 }
    };

    private static List<Department> _departments = new List<Department>
    {
        new Department { Id = 1, Name = "IT" },
        new Department { Id = 2, Name = "HR" },
        new Department { Id = 3, Name = "Finance" },
        new Department { Id = 4, Name = "Sales" }
    };

    private StudentDetailsDto ToStudentDetailsDto(Student student) {
        var department = _departments
            .FirstOrDefault(d => d.Id == student.DepartmentId);

        return new StudentDetailsDto
        {
            Id = student.Id,
            Name = student.Name,
            Age = student.Age,
            DepartmentName = department?.Name ?? "Unknown"
        };
    }

    public List<StudentDetailsDto> GetAllStudents() {
        return _students
            .Select(s => ToStudentDetailsDto(s))
            .ToList();
    }

    public StudentDetailsDto? GetStudentById(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);

        if (student == null)
        {
            return null;
        }

        return ToStudentDetailsDto(student);
    }

    public List<StudentDetailsDto> SearchStudentsByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return new List<StudentDetailsDto>();
        }

        return _students
            .Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            .Select(s => ToStudentDetailsDto(s))
            .ToList();
    }

    public List<StudentDetailsDto> FilterStudentsByAge()
    {
        return _students
            .Where(s => s.Age >= 18 && s.Age <= 22)
            .OrderBy(s => s.Age)
            .Select(s => ToStudentDetailsDto(s))
            .ToList();
    }

    public StudentDetailsDto? AddStudent(CreateStudentDto dto)
    {
        var departmentExists = _departments.Any(d => d.Id == dto.DepartmentId);

        if (!departmentExists)
        {
            return null;
        }

        int newId = _students.Count > 0
            ? _students.Max(s => s.Id) + 1
            : 1;

        var student = new Student
        {
            Id = newId,
            Name = dto.Name,
            Age = dto.Age,
            DepartmentId = dto.DepartmentId
        };

        _students.Add(student);

        return ToStudentDetailsDto(student);
    }

    public string? UpdateStudent(int id, UpdateStudentDto dto)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);

        if (student == null)
        {
            return "StudentNotFound";
        }

        var departmentExists = _departments.Any(d => d.Id == dto.DepartmentId);

        if (!departmentExists)
        {
            return "DepartmentNotFound";
        }

        student.Name = dto.Name;
        student.Age = dto.Age;
        student.DepartmentId = dto.DepartmentId;

        return null;
    }

    public bool DeleteStudent(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);

        if (student == null)
        {
            return false;
        }

        _students.Remove(student);

        return true;
    }

    public List<Student> GetStudentsForStatistics()
    {
        return _students;
    }
}