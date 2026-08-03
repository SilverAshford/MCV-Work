namespace Task_C_
{
    internal enum StudentStatus
    {
        Active = 1,
        Graduated = 2,
        Suspended = 3
    }
    internal class Program
    {
        static void Main(string[] args) {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // // Print a welcome message to the console
            // Console.WriteLine("Welcome to C#.");
            // // Print personal name on a separate line
            // Console.WriteLine("Name: Youssef Soliman.");
            // // Print age on a separate line
            // Console.WriteLine("Age: 20.");
            // // Print department on a separate line
            // Console.WriteLine("Department: Computer Science.");
            // Console.WriteLine as print in python, moving to new line.

            // Console.Write("Enter student name: ");
            // string name = Console.ReadLine();

            // Console.Write("Enter student age: ");
            // int age = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter student department: ");
            // string department = Console.ReadLine();

            // Console.Write("Enter student grade: ");
            // double grade = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("\n--- Student Information ---");
            // Console.WriteLine("Name: " + name);
            // Console.WriteLine("Age: " + age);
            // Console.WriteLine("Department: " + department);
            // Console.WriteLine("Grade: " + grade);


            // Console.WriteLine("\n=========================\n");

            // Console.Write("Enter first number: ");
            // double num1 = Convert.ToDouble(Console.ReadLine());

            // Console.Write("Enter second number: ");
            // double num2 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("\n--- Results ---");
            // Console.WriteLine("Addition: " + (num1 + num2));
            // Console.WriteLine("Subtraction: " + (num1 - num2));
            // Console.WriteLine("Multiplication: " + (num1 * num2));

            // Console.WriteLine("\n=========================\n");

            // if (num2 != 0)
            // {
            //     Console.WriteLine("Division: " + (num1 / num2));
            //     Console.WriteLine("Modulus: " + (num1 % num2));
            // }
            // else
            // {
            //     Console.WriteLine("Division: Cannot divide by zero!");
            //     Console.WriteLine("Modulus: Not Available for 0");
            // }

            // Console.WriteLine("\n=========================\n");

            // bool exit = false;

            // while (!exit)
            // {
            //     Console.WriteLine("\n--- Calculator Menu ---");
            //     Console.WriteLine("1. Add");
            //     Console.WriteLine("2. Subtract");
            //     Console.WriteLine("3. Multiply");
            //     Console.WriteLine("4. Divide");
            //     Console.WriteLine("5. Modulus");
            //     Console.WriteLine("6. Exit");
            //     Console.Write("Choose an option (1-6): ");

            //     int choice = Convert.ToInt32(Console.ReadLine());

            //     if (choice >= 1 && choice <= 5)
            //     {
            //         Console.Write("Enter first number: ");
            //         double num1 = Convert.ToDouble(Console.ReadLine());

            //         Console.Write("Enter second number: ");
            //         double num2 = Convert.ToDouble(Console.ReadLine());

            //         switch (choice)
            //         {
            //             case 1:
            //                 Console.WriteLine("Result: " + (num1 + num2));
            //                 break;
            //             case 2:
            //                 Console.WriteLine("Result: " + (num1 - num2));
            //                 break;
            //             case 3:
            //                 Console.WriteLine("Result: " + (num1 * num2));
            //                 break;
            //             case 4:
            //                 if (num2 != 0)
            //                 {
            //                     Console.WriteLine("Result: " + (num1 / num2));
            //                 }
            //                 else
            //                 {
            //                     Console.WriteLine("Cannot divide by zero!");
            //                 }
            //                 break;
            //             case 5:
            //                 if (num2 != 0)
            //                 {
            //                     Console.WriteLine("Result: " + (num1 % num2));
            //                 }
            //                 else
            //                 {
            //                     Console.WriteLine("Cannot calculate modulus by zero!");
            //                 }
            //                 break;
            //         }
            //     }
            //     else if (choice == 6)
            //     {
            //         exit = true;
            //         Console.WriteLine("Exiting program... Goodbye!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Invalid choice! Please select a valid option.");
            //     }
            // }

            // Console.WriteLine("\n=========================\n");

            // Console.Write("Enter your grade (0 - 100): ");
            // double grade = Convert.ToDouble(Console.ReadLine());

            // switch (grade)
            // {
            //     case < 0 or > 100:
            //         Console.WriteLine("Error: Invalid grade! Please enter a number between 0 and 100.");
            //         break;
            //     case >= 85:
            //         Console.WriteLine("Result: Excellent");
            //         break;
            //     case >= 75:
            //         Console.WriteLine("Result: Very Good");
            //         break;
            //     case >= 65:
            //         Console.WriteLine("Result: Good");
            //         break;
            //     case >= 50:
            //         Console.WriteLine("Result: Pass");
            //         break;
            //     default:
            //         Console.WriteLine("Result: Fail");
            //         break;
            // }

            // Console.WriteLine("\n=========================\n");

            // Console.Write("Enter your age: ");
            // bool isNumber = int.TryParse(Console.ReadLine(), out int age);

            // bool isValidAge = isNumber && age >= 0 && age <= 120;

            // if (isValidAge)
            // {
            //     if (age <= 12)
            //     {
            //         Console.WriteLine("Category: Child");
            //     }
            //     else if (age <= 19)
            //     {
            //         Console.WriteLine("Category: Teenager");
            //     }
            //     else if (age <= 64)
            //     {
            //         Console.WriteLine("Category: Adult");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Category: Senior");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Error: Please enter a valid numeric age.");
            // }

            // Console.WriteLine("\n=========================\n");

            // Console.Write("Enter your first name: ");
            // string firstName = Console.ReadLine()!;

            // Console.Write("Enter your last name: ");
            // string lastName = Console.ReadLine()!;

            // string fullName = firstName + " " + lastName;

            // Console.WriteLine("\n--- Name Details ---");
            // Console.WriteLine("Full Name: " + fullName);
            // Console.WriteLine("Uppercase: " + fullName.ToUpper());
            // Console.WriteLine("Lowercase: " + fullName.ToLower());
            // int charCount = fullName.Replace(" ", "").Length;
            // Console.WriteLine("Total Characters: " + charCount);

            // if (fullName.ToLower().Contains('a'))
            // {
            //     Console.WriteLine("Contains letter 'a': Yes");
            // }
            // else
            // {
            //     Console.WriteLine("Contains letter 'a': No");
            // }

            // Console.WriteLine("\n=========================\n");

            // double[] numbers = new double[5];

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.Write($"Enter number {i + 1}: ");
            //     numbers[i] = Convert.ToDouble(Console.ReadLine());
            // }

            // double total = 0;
            // double max = numbers[0];
            // double min = numbers[0];

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     total += numbers[i];
            //     max = Math.Max(max, numbers[i]);
            //     min = Math.Min(min, numbers[i]);
            // }

            // double average = total / numbers.Length;

            // Console.WriteLine("\n--- Results ---");
            // Console.WriteLine("Total: " + total);
            // Console.WriteLine("Average: " + average);
            // Console.WriteLine("Maximum: " + max);
            // Console.WriteLine("Minimum: " + min);

            // Console.WriteLine("\n=========================\n");

            // Console.WriteLine("--- Example 1: For Loop ---");

            // for (int i = 1; i <= 20; i++)
            // {
            //     if (i == 17)
            //     {
            //         break;
            //     }

            //     if (i % 3 == 0)
            //     {
            //         continue;
            //     }

            //     Console.WriteLine(i);
            // }

            // Console.WriteLine("\n--- Example 2: While Loop ---");

            // int counter = 1;

            // while (counter <= 20)
            // {
            //     if (counter == 17)
            //     {
            //         break;
            //     }

            //     if (counter % 3 == 0)
            //     {
            //         counter++;
            //         continue;
            //     }

            //     Console.WriteLine(counter);
            //     counter++;
            // }

            // Console.WriteLine("\n=========================\n");

            // string[] names = new string[5];
            // int[] ages = new int[5];

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.Write($"Enter name for student {i + 1}: ");
            //     names[i] = Console.ReadLine()!;

            //     Console.Write($"Enter age for {names[i]}: ");
            //     while (!int.TryParse(Console.ReadLine(), out ages[i]) || ages[i] < 0)
            //     {
            //         Console.Write("Invalid age! Please enter a valid number: ");
            //     }
            // }

            // Console.WriteLine("\n--- Students Aged Between 18 and 22 ---");
            // bool foundAny = false;

            // for (int i = 0; i < 5; i++)
            // {
            //     if (ages[i] >= 18 && ages[i] <= 22)
            //     {
            //         Console.WriteLine($"- {names[i]} ({ages[i]} years old)");
            //         foundAny = true;
            //     }
            // }

            // if (!foundAny)
            // {
            //     Console.WriteLine("No students found in this age range.");
            // }

            // int oldestAge = ages[0];
            // int youngestAge = ages[0];

            // for (int i = 1; i < ages.Length; i++)
            // {
            //     if (ages[i] > oldestAge)
            //     {
            //         oldestAge = ages[i];
            //     }

            //     if (ages[i] < youngestAge)
            //     {
            //         youngestAge = ages[i];
            //     }
            // }

            // Console.WriteLine("\n--- Age Statistics ---");
            // Console.WriteLine("Oldest Age: " + oldestAge);
            // Console.WriteLine("Youngest Age: " + youngestAge);

            // Console.WriteLine("\n=========================\n");

            // Console.Write("Enter student name: ");
            // string name = Console.ReadLine()!;

            // int age = ReadInteger("Enter student age: ");

            // double grade = ReadDouble("Enter student grade (0-100): ");

            // string gradeResult = CalculateGradeResult(grade);

            // Console.WriteLine("\n--- Student Details ---");
            // PrintStudentInfo(name, age, gradeResult);

            // Console.WriteLine("\n=========================\n");

            // Console.WriteLine("--- Task 12: Overloaded Methods Output ---\n");

            // PrintStudent("Youssef");

            // Console.WriteLine("-----------------------------");

            // PrintStudent("Youssef", 20);

            // Console.WriteLine("-----------------------------");

            // PrintStudent("Youssef", 20, "Computer Science");

            // Console.WriteLine("\n=========================\n");

            // Console.WriteLine("--- Task 13: Student Class Output ---\n");

            // Student student1 = new Student(1, "Youssef", 20, 88.5, "Computer Science");
            // Student student2 = new Student(2, "Ahmed", 22, 79.0, "Information Systems");

            // Console.WriteLine("Student 1 Details:");
            // student1.DisplayInfo();

            // Console.WriteLine("-----------------------------");

            // Console.WriteLine("Student 2 Details:");
            // student2.DisplayInfo();

            // Console.WriteLine("\n=========================\n");

            // Console.WriteLine("--- Task 14: Department Class & Lists Output ---\n");

            // List<Department> departments = new List<Department>()
            // {
            //     new Department(1, "Computer Science"),
            //     new Department(2, "Information Systems")
            // };

            // List<Student> students = new List<Student>()
            // {
            //     new Student(1, "Youssef", 20, 88.5, departments[0].Name),
            //     new Student(2, "Ahmed", 22, 79.0, departments[1].Name)
            // };

            // foreach (var student in students)
            // {
            //     Console.WriteLine($"Student: {student.Name} | Department: {student.DepartmentName}");
            // }

            // Console.WriteLine("\n=========================\n");

            // Console.WriteLine("--- Task 15: Validation & Access Modifiers Output ---\n");

            // Student validStudent = new Student(1, "Youssef", 20, 88.5, "Computer Science");
            // validStudent.DisplayInfo();

            // Console.WriteLine("-----------------------------");

            // Student invalidStudent = new Student(2, "Ahmed", 3, 105.0, "Information Systems");
            // invalidStudent.DisplayInfo();

            // Console.WriteLine("\n=========================\n");

            // Console.WriteLine("--- Task 16: Inheritance Output ---\n");

            // Student student = new Student(1, "Youssef", 20, 92.5, "Computer Science");
            // Teacher teacher = new Teacher(101, "Dr. Mohamed", 45, "C# Programming", 15000);

            // Console.WriteLine("Student Details:");
            // student.DisplayInfo();

            // Console.WriteLine("-----------------------------");

            // Console.WriteLine("Teacher Details:");
            // teacher.DisplayInfo();

            // Console.WriteLine("\n=========================\n");

            // Console.WriteLine("--- Task 17: Polymorphism Output ---\n");

            // List<Person> people = new List<Person>()
            // {
            //     new Student(1, "Youssef", 20, 92.5, "Computer Science"),
            //     new Student(2, "Sara", 21, 85.0, "Information Systems"),
            //     new Teacher(101, "Dr. Mohamed", 45, "C# Programming", 15000),
            //     new Teacher(102, "Dr. Khaled", 50, "Database Systems", 18000)
            // };

            // foreach (var person in people)
            // {
            //     person.DisplayInfo();
            //     Console.WriteLine("-----------------------------");
            // }

            // Console.WriteLine("\n=========================\n");

            // Console.WriteLine("--- Task 18: Abstraction and Interface Output ---\n");

            // List<Student> studentList = new List<Student>()
            // {
            //     new Student(1, "Youssef", 20, 92.5, "Computer Science"),
            //     new Student(2, "Sara", 21, 85.0, "Information Systems"),
            //     new Student(3, "Ahmed", 22, 78.0, "Computer Science")
            // };

            // Report report = new StudentReport(studentList);
            // report.PrintReport();

            // ISearchable searcher = new StudentSearcher(studentList);
            // searcher.Search("Youssef");

            // Console.WriteLine("\n=========================\n");

            // Console.WriteLine("--- Task 19: Enum Output ---\n");

            // Console.WriteLine("Select Student Status:");
            // Console.WriteLine("1. Active");
            // Console.WriteLine("2. Graduated");
            // Console.WriteLine("3. Suspended");

            // int statusInput = ReadInteger("Enter status number (1-3): ");
            // while (statusInput < 1 || statusInput > 3)
            // {
            //     statusInput = ReadInteger("Invalid choice! Enter a number between 1 and 3: ");
            // }

            // StudentStatus selectedStatus = (StudentStatus)statusInput;

            // Student newStudent = new Student(4, "Omar", 23, 91.0, "Computer Science", selectedStatus);

            // Console.WriteLine("\nStudent Added Successfully:\n");
            // newStudent.DisplayInfo();

            // Console.WriteLine("\n=========================\n");

            RunStudentMenu();

        }

        static int ReadInteger(string prompt)
        {
            int number;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.Write("Invalid input! Please enter a valid non-negative integer: ");
            }
            return number;
        }

        static double ReadDouble(string prompt)
        {
            double number;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out number) || number < 0 || number > 100)
            {
                Console.Write("Invalid input! Please enter a grade between 0 and 100: ");
            }
            return number;
        }

        static string CalculateGradeResult(double grade)
        {
            return grade switch
            {
                >= 85 => "Excellent",
                >= 75 => "Very Good",
                >= 65 => "Good",
                >= 50 => "Pass",
                _ => "Fail"
            };
        }

        static void PrintStudentInfo(string name, int age, string gradeResult)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade Result: {gradeResult}");
        }

        static void PrintStudent(string name)
        {
            Console.WriteLine($"Student Name: {name}");
        }

        static void PrintStudent(string name, int age)
        {
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Student Age: {age}");
        }

        static void PrintStudent(string name, int age, string department)
        {
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Student Age: {age}");
            Console.WriteLine($"Department: {department}");
        }

        internal class Person {
            private int _age;

            public int Id { get; set; }
            public string Name { get; set; }

            public int Age
            {
                get { return _age; }
                set
                {
                    if (value < 5)
                    {
                        Console.WriteLine($"Error: Age ({value}) cannot be less than 5.");
                    }
                    else
                    {
                        _age = value;
                    }
                }
            }

            public Person(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
            }
        }

        internal class Student : Person {
            private double _grade;

            public string DepartmentName { get; set; }
            
            public StudentStatus Status { get; set; } 

            public double Grade
            {
                get { return _grade; }
                set
                {
                    if (value < 0 || value > 100)
                    {
                        Console.WriteLine($"Error: Grade ({value}) must be between 0 and 100.");
                    }
                    else
                    {
                        _grade = value;
                    }
                }
            }

            public Student(int id, string name, int age, double grade, string departmentName, StudentStatus status = StudentStatus.Active) 
                : base(id, name, age)
            {
                Grade = grade;
                DepartmentName = departmentName;
                Status = status;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Grade: {Grade}");
                Console.WriteLine($"Department: {DepartmentName}");
                Console.WriteLine($"Status: {Status}"); 
            }
        }

        internal class Teacher : Person
        {
            public string Subject { get; set; }
            public double Salary { get; set; }

            public Teacher(int id, string name, int age, string subject, double salary) 
                : base(id, name, age)
            {
                Subject = subject;
                Salary = salary;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Subject: {Subject}");
                Console.WriteLine($"Salary: {Salary}");
            }
        }

        internal class Department {
            public int Id { get; set; }
            public string Name { get; set; }

            public Department(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        internal abstract class Report {
            public abstract void PrintReport();
        }

        internal class StudentReport : Report
        {
            private List<Student> _students;

            public StudentReport(List<Student> students)
            {
                _students = students;
            }

            public override void PrintReport()
            {
                Console.WriteLine("=== STUDENT SYSTEM REPORT ===");
                foreach (var student in _students)
                {
                    student.DisplayInfo();
                    Console.WriteLine("-----------------------------");
                }
            }
        }

        internal interface ISearchable
        {
            void Search(string keyword);
        }

        internal class StudentSearcher : ISearchable
        {
            private List<Student> _students;

            public StudentSearcher(List<Student> students)
            {
                _students = students;
            }

            public void Search(string keyword)
            {
                Console.WriteLine($"Search results for keyword: '{keyword}'");

                var results = _students
                    .Where(s => s.Name.ToLower().Contains(keyword.ToLower()))
                    .ToList();

                if (results.Count == 0)
                {
                    Console.WriteLine("No matching students found.");
                }
                else
                {
                    foreach (var student in results)
                    {
                        student.DisplayInfo();
                        Console.WriteLine("-----------------------------");
                    }
                }
            }
        }

        public static void RunStudentMenu()
        {
            List<Student> students = LoadStudentsFromFile();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Student Management Menu ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Edit Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                Console.WriteLine("7. Department Statistics");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        AddStudent(students);
                        break;
                    case "2":
                        ShowAllStudents(students);
                        break;
                    case "3":
                        SearchStudent(students);
                        break;
                    case "4":
                        EditStudent(students);
                        break;
                    case "5":
                        DeleteStudent(students);
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;
                    case "7":
                        ShowDepartmentStatistics(students);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static List<Student> LoadStudentsFromFile()
        {
            List<Student> students = new List<Student>();
            string filePath = "students.txt";

            if (!File.Exists(filePath))
            {
                return students;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split('|');

                if (parts.Length < 5)
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

                string departmentName = parts[4];

                StudentStatus status = StudentStatus.Active;

                if (parts.Length >= 6 && int.TryParse(parts[5], out int statusValue))
                {
                    if (statusValue >= 1 && statusValue <= 3)
                    {
                        status = (StudentStatus)statusValue;
                    }
                }

                students.Add(new Student(id, name, age, grade, departmentName, status));
            }

            return students;
        }

        private static void SaveStudentsToFile(List<Student> students)
        {
            List<string> lines = new List<string>();

            foreach (var student in students)
            {
                lines.Add($"{student.Id}|{student.Name}|{student.Age}|{student.Grade}|{student.DepartmentName}|{(int)student.Status}");
            }

            File.WriteAllLines("students.txt", lines);
        }

        private static string ReadText(string prompt)
        {
            Console.Write(prompt);
            string text = Console.ReadLine() ?? "";

            while (string.IsNullOrWhiteSpace(text))
            {
                Console.Write("Invalid input! Please enter a valid value: ");
                text = Console.ReadLine() ?? "";
            }

            return text.Trim();
        }

        private static StudentStatus ReadStudentStatus()
        {
            Console.WriteLine("Select Student Status:");
            Console.WriteLine("1. Active");
            Console.WriteLine("2. Graduated");
            Console.WriteLine("3. Suspended");

            int statusInput = ReadInteger("Enter status number (1-3): ");
            while (statusInput < 1 || statusInput > 3)
            {
                statusInput = ReadInteger("Invalid choice! Enter a number between 1 and 3: ");
            }

            return (StudentStatus)statusInput;
        }

        private static void AddStudent(List<Student> students)
        {
            int id = ReadInteger("Enter ID: ");

            while (students.Exists(s => s.Id == id))
            {
                id = ReadInteger("ID already exists! Enter a different ID: ");
            }

            string name = ReadText("Enter Name: ");
            int age = ReadInteger("Enter Age: ");
            double grade = ReadDouble("Enter Grade: ");
            string dept = ReadText("Enter Department Name: ");
            StudentStatus status = ReadStudentStatus();

            students.Add(new Student(id, name, age, grade, dept, status));
            SaveStudentsToFile(students);
            Console.WriteLine("Student added successfully!");
        }

        private static void ShowAllStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (var student in students)
            {
                student.DisplayInfo();
                Console.WriteLine("-----------------------");
            }
        }

        private static void SearchStudent(List<Student> students)
        {
            string query = ReadText("Enter Name or Department to search: ");

            List<Student> results = students.FindAll(s =>
                s.Name.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                s.DepartmentName.Equals(query, StringComparison.OrdinalIgnoreCase)
            );

            if (results.Count > 0)
            {
                Console.WriteLine($"\nFound {results.Count} student(s):");
                foreach (var student in results)
                {
                    student.DisplayInfo();
                    Console.WriteLine("-----------------------");
                }
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        private static void EditStudent(List<Student> students)
        {
            int id = ReadInteger("Enter Student ID to edit: ");

            Student? student = students.Find(s => s.Id == id);
            if (student != null)
            {
                student.Name = ReadText("Enter New Name: ");
                student.Age = ReadInteger("Enter New Age: ");
                student.Grade = ReadDouble("Enter New Grade: ");
                student.DepartmentName = ReadText("Enter New Department Name: ");
                student.Status = ReadStudentStatus();

                SaveStudentsToFile(students);
                Console.WriteLine("Student updated successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        private static void DeleteStudent(List<Student> students)
        {
            int id = ReadInteger("Enter Student ID to delete: ");

            Student? student = students.Find(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                SaveStudentsToFile(students);
                Console.WriteLine("Student deleted successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        private static void ShowDepartmentStatistics(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found to display statistics.");
                return;
            }

            var departmentGroups = students.GroupBy(s => s.DepartmentName).ToList();

            Console.WriteLine("\n=== Department Statistics ===");
            foreach (var group in departmentGroups)
            {
                Console.WriteLine($"\nDepartment: {group.Key}");
                Console.WriteLine($"Number of Students: {group.Count()}");
                Console.WriteLine($"Average Age: {group.Average(s => s.Age):F1}");
                Console.WriteLine($"Oldest Age: {group.Max(s => s.Age)}");
                Console.WriteLine($"Youngest Age: {group.Min(s => s.Age)}");
            }

            var highestDept = departmentGroups.OrderByDescending(g => g.Count()).FirstOrDefault();
            var lowestDept = departmentGroups.OrderBy(g => g.Count()).FirstOrDefault();

            Console.WriteLine("\n---------------------------------");
            if (highestDept != null)
            {
                Console.WriteLine($"Department with Most Students: {highestDept.Key} ({highestDept.Count()} students)");
            }

            if (lowestDept != null)
            {
                Console.WriteLine($"Department with Fewest Students: {lowestDept.Key} ({lowestDept.Count()} students)");
            }
        }
    }
}