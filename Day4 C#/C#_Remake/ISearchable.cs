public interface ISearchable
{
    void Search(string keyword);
}

public class StudentSearch : ISearchable
{
    private List<Student> _students;

    public StudentSearch(List<Student> students)
    {
        _students = students;
    }

    public void Search(string keyword)
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
            Console.WriteLine("No students found with this name.");
        }
    }
}