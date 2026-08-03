USE StudentManagementDb;

SELECT * FROM vw_StudentDetails;

SELECT * FROM vw_DepartmentStatistics;

CALL sp_InsertDepartment('Artificial Intelligence');

CALL sp_InsertStudent('Mahmoud Hassan', 22, 'mahmoud.hassan@example.com', 1);

CALL sp_UpdateStudent(1, 'Ahmed Ali', 23, 'ahmed.7@example.com', 2);

CALL sp_DeleteStudent(14);

CALL sp_GetAllStudents();

CALL sp_SearchStudents('Ahmed');
CALL sp_SearchStudents('CyberSecurity');

CALL sp_GetDepartmentStatistics();

CALL sp_GetHighestAndLowestDepartments();