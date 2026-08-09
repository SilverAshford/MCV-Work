public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(int id, string name, int age, string subject)
        : base(id, name, age)
    {
        Subject = subject;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[Teacher] ID: {Id} | Name: {Name} | Age: {Age} | Subject: {Subject}");
    }
}