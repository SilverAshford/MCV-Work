public enum StudentStatus
{
    Active = 1,
    Graduated,
    Suspended
}

public class Student : Person
{
    private double _grade;

    public Department Department { get; set; }
    public StudentStatus Status { get; set; }

    public string DepartmentName
    {
        get { return Department?.Name ?? ""; }
        set
        {
            if (Department == null)
            {
                Department = new Department(0, value);
            }
            else
            {
                Department.Name = value;
            }
        }
    }

    public double Grade
    {
        get { return _grade; }
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Invalid Grade! Grade must be between 0 and 100.");
            }
            else
            {
                _grade = value;
            }
        }
    }

    // Task 13
    public Student(int id, string name, int age, double grade, string departmentName)
        : this(id, name, age, grade, new Department(0, departmentName), StudentStatus.Active)
    {
    }

    // Task 14 / 15 / 16 / 17 / 18
    public Student(int id, string name, int age, double grade, Department department)
        : this(id, name, age, grade, department, StudentStatus.Active)
    {
    }

    // Task 19 / 20+
    public Student(int id, string name, int age, double grade, Department department, StudentStatus status)
        : base(id, name, age)
    {
        Grade = grade;
        Department = department;
        Status = status;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id} | Name: {Name} | Age: {Age} | Grade: {Grade} | Dept: {Department?.Name} | Status: {Status}");
    }
}