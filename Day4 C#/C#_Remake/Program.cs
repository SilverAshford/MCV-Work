using System;

class Program {
    static void Main(string[] args) {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Task 1

            Console.WriteLine("Welcome to C#.");
            Console.WriteLine("Name: Youssef");
            Console.WriteLine("Age: 20");
            Console.WriteLine("Department: CS");

            /* Console.WriteLine works as print in python, moving to the next line when print is over.
            we can use "\n" as well to move to the next line, but the format is gonna be messy. 
            */

            Console.WriteLine("\n========================\n");

            // Task 2

            string name, department;
            int age;
            float grade;

            Console.Write("Enter your name: ");
            name = Console.ReadLine()!;

            age = InputHelper.ReadInt("Enter your age: ");

            Console.Write("Enter your department: ");
            department = Console.ReadLine()!;

            grade = InputHelper.ReadFloat("Enter your grade: ");

            Console.WriteLine("------------------------------");

            Console.WriteLine($"Your name is: {name}.\nYour age is: {age}.\nYour department is: {department}.\nYour grade is: {grade}.");

            Console.WriteLine("\n========================\n");

            // Task 3 & 4
            
            float number1, number2;
            int answer;

            Console.WriteLine("This is a calculator program.");

            number1 = InputHelper.ReadFloat("Enter number 1: ");

            number2 = InputHelper.ReadFloat("Enter number 2: ");

            Console.WriteLine(@"
            1.Addition
            2.Subtraction
            3.Multiplication
            4.Division
            5.Modulus
            ");

            while (true) {

                answer = InputHelper.ReadInt("Enter your choice: ");

                bool exit_loop = true;

                switch (answer) {
                    case 1:
                        Console.WriteLine("Result: " + (number1 + number2));
                        break;
                    case 2:
                        Console.WriteLine("Result: " + (number1 - number2));
                        break;
                    case 3:
                        Console.WriteLine("Result: " + (number1 * number2));
                        break;
                    case 4:
                        if (number2 != 0) {
                            Console.WriteLine("Result: " + (number1 / number2));
                        }
                        else {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;

                    case 5:
                        if (number2 != 0) {
                            Console.WriteLine("Result: " + (number1 % number2));
                        }
                        else {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        exit_loop = false;
                        break;
            }
            
            if (!exit_loop) {
                continue;
            }

            break;
        }   

        Console.WriteLine("\n========================\n");

        // Task 5

        float grade5;
        grade5 = InputHelper.ReadFloat("Enter your grade: ");

        Console.WriteLine(MethodHelper.GetGradeResult(grade5));

        Console.WriteLine("\n========================\n");

        // Task 6

        int age6;
        bool validAge;

        age6 = InputHelper.ReadInt("Enter your age: ");

        validAge = age6 >= 0 && age6 <= 120;

        if (!validAge)
        {
            Console.WriteLine("Invalid age. Please enter a value between 0 and 120.");
        }
        else if (age6 <= 12)
        {
            Console.WriteLine("Child");
        }
        else if (age6 <= 19)
        {
            Console.WriteLine("Teenager");
        }
        else if (age6 <= 64)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Senior");
        }

        Console.WriteLine("\n========================\n");

        // Task 7

        string firstName;
        string lastName;
        string fullName;
        int characterCount;
        bool containsLetterA;

        firstName = InputHelper.ReadString("Enter first name: ");
        lastName = InputHelper.ReadString("Enter last name: ");

        fullName = firstName + " " + lastName;

        Console.WriteLine("Full Name: " + fullName);
        Console.WriteLine("Uppercase: " + fullName.ToUpper());
        Console.WriteLine("Lowercase: " + fullName.ToLower());

        string fname = fullName.Replace(" ", "");
        characterCount = fname.Length;
        Console.WriteLine("Number of characters: " + characterCount);

        containsLetterA = fullName.Contains("a") || fullName.Contains("A");
        Console.WriteLine("Contains the letter 'a': " + containsLetterA);

        Console.WriteLine("\n========================\n");

        // Task 8

        double[] numbers = new double[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = InputHelper.ReadFloat("Enter number " + (i + 1) + ": ");
        }

        double total = 0;
        double max = numbers[0];
        double min = numbers[0];

        for (int i = 0; i < numbers.Length; i++) {
            total += numbers[i];
            max = Math.Max(max, numbers[i]);
            min = Math.Min(min, numbers[i]);
        }

        double average = total / numbers.Length;

        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Minimum: " + min);

        Console.WriteLine("\n========================\n");

        // Task 9

        Console.WriteLine("--- For Loop ---");
        for (int i = 1; i <= 20; i++) {

            if (i == 17) {
                break;
            }

            if (i % 3 == 0) {
                continue;
            }

            Console.WriteLine(i);
        }

        Console.WriteLine("\n--- While Loop ---");
        int k = 1;
        while (k <= 20) {

            if (k == 17) {
                break;
            }

            if (k % 3 == 0) {
                k++;
                continue;
            }

            Console.WriteLine(k);
            k++;
        }

        Console.WriteLine("\n========================\n");

        // Task 10

        string[] names = new string[5];
        int[] ages = new int[5];

        int oldestAge = ages[0];
        int youngestAge = ages[0];

        for (int i = 0; i < 5; i++) {
            names[i] = InputHelper.ReadString("Enter name for student " + (i + 1) + ": ");
            ages[i] = InputHelper.ReadInt("Enter age for student " + (i + 1) + ": ");
        }

        Console.WriteLine("----------------------------------");

        MethodHelper.PrintStudentInfo(names, ages);

        Console.WriteLine("\n========================\n");

        // Task 12

        MethodHelper.PrintStudent("Ahmed");
        MethodHelper.PrintStudent("Sara", 21);
        MethodHelper.PrintStudent("Omar", 23, "Computer Science");

        Console.WriteLine("\n========================\n");

        // Task 13

        Student student1 = new Student(1, "Ahmed", 20, 88.5, "Computer Science");
        Student student2 = new Student(2, "Sara", 22, 91.0, "Information Systems");

        student1.DisplayInfo();
        student2.DisplayInfo();

        Console.WriteLine("\n========================\n");

        // Task 14

        List<Department> departments = new List<Department> {
            new Department(1, "Computer Science"),
            new Department(2, "Information Systems")
        };

        List<Student> students = new List<Student> {
            new Student(101, "Ahmed", 20, 85.5, departments[0]),
            new Student(102, "Sara", 21, 92.0, departments[1])
        };

        foreach (var student in students) {
            Console.WriteLine($"Student: {student.Name} | Department: {student.Department.Name}");
        }

        Console.WriteLine("\n========================\n");

        // Task 15 & 16 & 17 (Classes files)

        Department csDept = new Department(1, "Computer Science");
        Department isDept = new Department(2, "Information Systems");

        List<Person> people = new List<Person> {
            new Student(101, "Ahmed", 20, 88.5, csDept),
            new Student(102, "Sara", 21, 91.0, isDept),
            new Teacher(201, "Dr. Mohamed", 45, "Programming"),
            new Teacher(202, "Dr. Mona", 39, "Database")
        };

        foreach (var person in people)
        {
            person.DisplayInfo();
        }

        Console.WriteLine("\n========================\n");

        // Task 18

        List<Student> studentList = new List<Student>
        {
            new Student(101, "Ahmed Ali", 20, 88.5, csDept),
            new Student(102, "Sara Mohamed", 21, 91.0, isDept),
            new Student(103, "Ahmed Hassan", 22, 79.0, csDept)
        };

        Report report = new StudentReport(studentList);
        report.PrintReport();

        ISearchable searchEngine = new StudentSearch(studentList);
        searchEngine.Search("Ahmed");

        Console.WriteLine("\n========================\n");

        // Task 19

        MethodHelper.student_Status();

        int choice = InputHelper.ReadInt("Enter choice (1-3): ");
        StudentStatus selectedStatus = (StudentStatus)choice;

        Student newStudent = new Student(101, "Ali Hassan", 20, 85.0, csDept, selectedStatus);

        Console.WriteLine("\n--- Student Details ---");
        newStudent.DisplayInfo();

        Console.WriteLine("\n========================\n");

        // Task 20 & 21 & 22 & 23 & 24

        StudentManager.LoadStudentsFromFile();

        bool running = true;

        while (running) {
            Console.WriteLine("\n==================================");
            Console.WriteLine("      STUDENT MANAGEMENT MENU     ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Edit Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Department Statistics");
            Console.WriteLine("7. Show All Departments");
            Console.WriteLine("8. Exit");
            
            int choice20 = InputHelper.ReadInt("Choose an option (1-8): ");
            Console.WriteLine();

            switch (choice20)
            {
                case 1:
                    StudentManager.AddStudentUI();
                    break;
                case 2:
                    StudentManager.ShowAllStudents();
                    break;
                case 3:
                    StudentManager.SearchStudentUI();
                    break;
                case 4:
                    StudentManager.EditStudentUI();
                    break;
                case 5:
                    StudentManager.DeleteStudentUI();
                    break;
                case 6:
                    StudentManager.ShowDepartmentStatistics();
                    break;
                case 7:
                    StudentManager.ShowAllDepartments();
                    break;
                case 8:
                    running = false;
                    Console.WriteLine("Exiting program... Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select between 1 and 8.");
                    break;
            }
        }
    }
}