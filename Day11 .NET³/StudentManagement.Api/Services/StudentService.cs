using StudentManagement.Api.DTOs;
using StudentManagement.Api.Models;
using StudentManagement.Api.Data;

namespace StudentManagement.Api.Services;

public class StudentService : IStudentService
{
    private readonly AppDbContext _context;

    public StudentService(AppDbContext context)
    {
        _context = context;
    }

    private StudentDetailsDto ToStudentDetailsDto(Student student) {
        var department = _context.Departments
            .FirstOrDefault(d => d.Id == student.DepartmentId);

        return new StudentDetailsDto
        {
            Id = student.Id,
            Name = student.Name,
            Age = student.Age,
            DepartmentName = department?.Name ?? "Unknown"
        };
    }

    public List<StudentDetailsDto> GetAllStudents()
    {
        var students = _context.Students.ToList();

        return students
            .Select(s => ToStudentDetailsDto(s))
            .ToList();
    }

    public StudentDetailsDto? GetStudentById(int id)
    {
        var student = _context.Students.FirstOrDefault(s => s.Id == id);

        if (student == null) {
            return null;
        }

        return ToStudentDetailsDto(student);
    }

    public List<StudentDetailsDto> SearchStudentsByName(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return new List<StudentDetailsDto>();
        }

        var students = _context.Students
            .Where(s =>
                s.Name.Contains(text) ||
                _context.Departments.Any(d =>
                    d.Id == s.DepartmentId &&
                    d.Name.Contains(text)))
            .ToList();

        return students
            .Select(s => ToStudentDetailsDto(s))
            .ToList();
    }

    public List<StudentDetailsDto> FilterStudentsByAge()
    {
        var students = _context.Students
            .Where(s => s.Age >= 18 && s.Age <= 22)
            .OrderBy(s => s.Age)
            .ToList();

        return students
            .Select(s => ToStudentDetailsDto(s))
            .ToList();
    }
    public StudentDetailsDto? AddStudent(CreateStudentDto dto)
    {
        var departmentExists = _context.Departments
            .Any(d => d.Id == dto.DepartmentId);

        if (!departmentExists)
        {
            return null;
        }

        var student = new Student
        {
            Name = dto.Name,
            Age = dto.Age,
            DepartmentId = dto.DepartmentId
        };

        _context.Students.Add(student);

        _context.SaveChanges();

        return ToStudentDetailsDto(student);
    }

    public string? UpdateStudent(int id, UpdateStudentDto dto)
    {
        var student = _context.Students.FirstOrDefault(s => s.Id == id);

        if (student == null)
        {
            return "StudentNotFound";
        }

        var departmentExists = _context.Departments.Any(d => d.Id == dto.DepartmentId);

        if (!departmentExists)
        {
            return "DepartmentNotFound";
        }

        student.Name = dto.Name;
        student.Age = dto.Age;
        student.DepartmentId = dto.DepartmentId;

        _context.SaveChanges();

        return null;
    }

    public bool DeleteStudent(int id)
    {
        var student = _context.Students.FirstOrDefault(s => s.Id == id);

        if (student == null)
        {
            return false;
        }

        _context.Students.Remove(student);

        _context.SaveChanges();

        return true;
    }

    public List<Student> GetStudentsForStatistics()
    {
        return _context.Students.ToList();
    }
}