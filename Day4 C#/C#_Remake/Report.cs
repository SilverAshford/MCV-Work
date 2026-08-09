public abstract class Report
{
    public abstract void PrintReport();
}

public class StudentReport : Report
{
    private List<Student> _students;

    public StudentReport(List<Student> students)
    {
        _students = students;
    }

    public override void PrintReport()
    {
        Console.WriteLine("=== Students Report ===");
        foreach (var student in _students)
        {
            student.DisplayInfo();
        }
    }
}