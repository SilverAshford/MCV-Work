using StudentManagement.Api.DTOs;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Services;

public interface IStudentService
{
    List<StudentDetailsDto> GetAllStudents();
    StudentDetailsDto? GetStudentById(int id);
    StudentDetailsDto? AddStudent(CreateStudentDto dto);
    string? UpdateStudent(int id, UpdateStudentDto dto);
    bool DeleteStudent(int id);
    List<StudentDetailsDto> SearchStudentsByName(string name);
    List<StudentDetailsDto> FilterStudentsByAge();

    List<Student> GetStudentsForStatistics();
}