using System;

public static class MethodHelper {
    public static string GetGradeResult(float grade) {
        if (grade < 0 || grade > 100)
        {
            return "Wrong value; grade must be between 0 and 100.";
        }
        else if (grade >= 85)
        {
            return "Excellent";
        }
        else if (grade >= 75)
        {
            return "Very Good";
        }
        else if (grade >= 65)
        {
            return "Good";
        }
        else if (grade >= 50)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }

    public static void PrintStudentInfo(string[] names, int[] ages) {
        int oldestAge = ages[0];
        int youngestAge = ages[0];

        Console.WriteLine("All Students:");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine((i + 1) + ". Name: " + names[i] + ", Age: " + ages[i]);

            oldestAge = Math.Max(oldestAge, ages[i]);
            youngestAge = Math.Min(youngestAge, ages[i]);
        }

        Console.WriteLine("\nStudents aged between 18 and 22:");
        for (int i = 0; i < names.Length; i++)
        {
            if (ages[i] >= 18 && ages[i] <= 22)
            {
                Console.WriteLine("- " + names[i] + " (" + ages[i] + " years old)");
            }
        }

        Console.WriteLine("\nOldest Age: " + oldestAge);
        Console.WriteLine("Youngest Age: " + youngestAge);
    }

    public static void PrintStudent(string name) {
        Console.WriteLine("Student Name: " + name);
    }

    public static void PrintStudent(string name, int age) {
        Console.WriteLine("Student Name: " + name + " | Age: " + age);
    }

    public static void PrintStudent(string name, int age, string department) {
        Console.WriteLine("Student Name: " + name + " | Age: " + age + " | Department: " + department);
    }

    public static void student_Status () {
        Console.WriteLine("Choose Student Status:");
        Console.WriteLine("1. Active");
        Console.WriteLine("2. Graduated");
        Console.WriteLine("3. Suspended");
    }
}



public static class InputHelper
{
    public static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);

            if (int.TryParse(Console.ReadLine(), out int value))
                return value;

            Console.WriteLine("Please enter a valid number.");
        }
    }

    public static float ReadFloat(string message)
    {
        while (true)
        {
            Console.Write(message);

            if (float.TryParse(Console.ReadLine(), out float value))
                return value;

            Console.WriteLine("Please enter a valid number.");
        }
    }

    public static string ReadString(string message) {
        while (true) {
            Console.Write(message);
            string input = Console.ReadLine()!;

            if (!string.IsNullOrWhiteSpace(input))
                return input;

            Console.WriteLine("Please enter a valid non-empty text.");
        }
    }
}

public static class MathHelper
{
    public static bool CanDivide(float number)
    {
        if (number == 0)
        {
            return false;
        }

        return true;
    }
}

public static class StudentManager
{
    private static List<Student> _students = new List<Student>();
    private static List<Department> _departments = new List<Department>();
    private static string _filePath = "students.txt";

    public static void AddStudent(Student student) {
        if (_students.Exists(s => s.Id == student.Id))
        {
            Console.WriteLine($"Error: A student with ID {student.Id} already exists!");
            return;
        }

        _students.Add(student);
        SaveStudentsToFile();
        Console.WriteLine("Student added successfully!");
    }

    public static void ShowAllStudents()
    {
        Console.WriteLine("\n--- All Students List ---");

        if (_students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        foreach (var student in _students)
        {
            student.DisplayInfo();
        }
    }

    public static void SearchStudentByName(string keyword)
    {
        Console.WriteLine($"\n--- Search Results for: '{keyword}' ---");
        bool found = false;

        foreach (var student in _students)
        {
            if (student.Name.ToLower().Contains(keyword.ToLower()))
            {
                student.DisplayInfo();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching students found.");
        }
    }

    public static void SearchStudentByDepartment(string keyword)
    {
        Console.WriteLine($"\n--- Search Results for Department: '{keyword}' ---");
        bool found = false;

        foreach (var student in _students)
        {
            if (student.Department != null && student.Department.Name.ToLower().Contains(keyword.ToLower()))
            {
                student.DisplayInfo();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching students found.");
        }
    }

    public static void EditStudent(int id, string newName, int newAge, double newGrade, StudentStatus newStatus)
    {
        Student student = FindById(id);

        if (student == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }

        student.Name = newName;
        student.Age = newAge;
        student.Grade = newGrade;
        student.Status = newStatus;

        SaveStudentsToFile();
        Console.WriteLine("Student updated successfully!");
    }

    public static void DeleteStudent(int id)
    {
        Student student = FindById(id);

        if (student == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }

        _students.Remove(student);
        SaveStudentsToFile();
        Console.WriteLine("Student deleted successfully!");
    }

    public static Student FindById(int id)
    {
        return _students.Find(s => s.Id == id)!;
    }

    private static int GetNextStudentId()
    {
        if (_students.Count == 0)
        {
            return 1;
        }

        return _students.Max(s => s.Id) + 1;
    }

    private static int GetNextDepartmentId()
    {
        if (_departments.Count == 0)
        {
            return 1;
        }

        return _departments.Max(d => d.Id) + 1;
    }

    private static StudentStatus ReadStudentStatus(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            int statusChoice = InputHelper.ReadInt("Choose (1-3): ");

            if (statusChoice >= 1 && statusChoice <= 3)
            {
                return (StudentStatus)statusChoice;
            }

            Console.WriteLine("Invalid status! Please choose 1, 2, or 3.");
        }
    }

    private static Department GetOrCreateDepartment(string deptName)
    {
        Department? dept = _departments.Find(d => d.Name.Equals(deptName, StringComparison.OrdinalIgnoreCase));

        if (dept == null)
        {
            int deptId = GetNextDepartmentId();
            dept = new Department(deptId, deptName);
            _departments.Add(dept);
        }

        return dept;
    }

    public static void AddStudentUI()
    {
        int id = GetNextStudentId();

        Console.WriteLine($"Student ID: {id}");

        string name = InputHelper.ReadString("Enter Name: ");
        int age = InputHelper.ReadInt("Enter Age: ");
        double grade = InputHelper.ReadFloat("Enter Grade (0-100): ");

        string deptName = InputHelper.ReadString("Enter Department Name: ");
        Department dept = GetOrCreateDepartment(deptName);

        StudentStatus status = ReadStudentStatus("Select Status (1. Active, 2. Graduated, 3. Suspended): ");

        Student newStudent = new Student(id, name, age, grade, dept, status);
        AddStudent(newStudent);
    }

    public static void SearchStudentUI()
    {
        Console.WriteLine("1. Search by Name");
        Console.WriteLine("2. Search by Department");
        int searchChoice = InputHelper.ReadInt("Choose (1-2): ");

        if (searchChoice == 1)
        {
            string keyword = InputHelper.ReadString("Enter student name to search: ");
            SearchStudentByName(keyword);
        }
        else if (searchChoice == 2)
        {
            string keyword = InputHelper.ReadString("Enter department name to search: ");
            SearchStudentByDepartment(keyword);
        }
        else
        {
            Console.WriteLine("Invalid choice! Please select 1 or 2.");
        }
    }

    public static void EditStudentUI()
    {
        int editId = InputHelper.ReadInt("Enter Student ID to edit: ");
        Student existingStudent = FindById(editId);

        if (existingStudent != null)
        {
            string newName = InputHelper.ReadString($"Enter New Name (Current: {existingStudent.Name}): ");
            int newAge = InputHelper.ReadInt($"Enter New Age (Current: {existingStudent.Age}): ");
            double newGrade = InputHelper.ReadFloat($"Enter New Grade (Current: {existingStudent.Grade}): ");

            string deptName = InputHelper.ReadString($"Enter New Department (Current: {existingStudent.Department.Name}): ");
            existingStudent.Department = GetOrCreateDepartment(deptName);

            StudentStatus newStatus = ReadStudentStatus("Select New Status (1. Active, 2. Graduated, 3. Suspended): ");

            EditStudent(
                editId,
                newName,
                newAge,
                newGrade,
                newStatus
            );
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    public static void DeleteStudentUI()
    {
        int deleteId = InputHelper.ReadInt("Enter Student ID to delete: ");
        DeleteStudent(deleteId);
    }

    // Task 22 - Department Statistics
    public static void ShowAllDepartments()
    {
        Console.WriteLine("\n--- All Departments List ---");

        if (_departments.Count == 0)
        {
            Console.WriteLine("No departments found.");
            return;
        }

        foreach (var dept in _departments)
        {
            Console.WriteLine("ID: " + dept.Id + " | Name: " + dept.Name);
        }
    }

    public static void ShowDepartmentStatistics()
    {
        Console.WriteLine("\n--- Department Statistics ---");

        if (_students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        string highestDept = "";
        string lowestDept = "";
        int highestCount = int.MinValue;
        int lowestCount = int.MaxValue;

        foreach (var dept in _departments)
        {
            List<Student> deptStudents = _students.FindAll(s => s.Department != null && s.Department.Id == dept.Id);

            if (deptStudents.Count == 0)
            {
                continue;
            }

            int count = deptStudents.Count;
            double totalAge = 0;
            int oldestAge = deptStudents[0].Age;
            int youngestAge = deptStudents[0].Age;

            foreach (var student in deptStudents)
            {
                totalAge += student.Age;
                oldestAge = Math.Max(oldestAge, student.Age);
                youngestAge = Math.Min(youngestAge, student.Age);
            }

            double averageAge = totalAge / count;

            Console.WriteLine("\nDepartment: " + dept.Name);
            Console.WriteLine("Number of students: " + count);
            Console.WriteLine("Average age: " + averageAge);
            Console.WriteLine("Oldest age: " + oldestAge);
            Console.WriteLine("Youngest age: " + youngestAge);

            if (count > highestCount)
            {
                highestCount = count;
                highestDept = dept.Name;
            }

            if (count < lowestCount)
            {
                lowestCount = count;
                lowestDept = dept.Name;
            }
        }

        Console.WriteLine("\nDepartment with highest number of students: " + highestDept + " (" + highestCount + ")");
        Console.WriteLine("Department with lowest number of students: " + lowestDept + " (" + lowestCount + ")");
    }

    // Task 23 - File as a Simple Database
    public static void LoadStudentsFromFile()
    {
        if (!File.Exists(_filePath))
        {
            return;
        }

        string[] lines = File.ReadAllLines(_filePath);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            string[] parts = line.Split('|');

            if (parts.Length < 7)
            {
                continue;
            }

            if (!int.TryParse(parts[0], out int id))
            {
                continue;
            }

            string name = parts[1];

            if (!int.TryParse(parts[2], out int age))
            {
                continue;
            }

            if (!double.TryParse(parts[3], out double grade))
            {
                continue;
            }

            if (!int.TryParse(parts[4], out int deptId))
            {
                continue;
            }

            string deptName = parts[5];

            StudentStatus status;
            if (!Enum.TryParse(parts[6], true, out status) || !Enum.IsDefined(typeof(StudentStatus), status))
            {
                continue;
            }

            Department? dept = _departments.Find(d => d.Id == deptId);

            if (dept == null)
            {
                dept = new Department(deptId, deptName);
                _departments.Add(dept);
            }

            if (_students.Exists(s => s.Id == id))
            {
                continue;
            }

            Student student = new Student(id, name, age, grade, dept, status);
            _students.Add(student);
        }

        Console.WriteLine("Students loaded from file successfully!");
    }

    public static void SaveStudentsToFile()
    {
        List<string> lines = new List<string>();

        foreach (var student in _students)
        {
            string line =
                student.Id + "|" +
                student.Name + "|" +
                student.Age + "|" +
                student.Grade + "|" +
                student.Department.Id + "|" +
                student.Department.Name + "|" +
                student.Status;

            lines.Add(line);
        }

        File.WriteAllLines(_filePath, lines);
    }
}
