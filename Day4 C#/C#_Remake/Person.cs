public class Person
{
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
                Console.WriteLine("Invalid Age! Age cannot be less than 5.");
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
        Console.WriteLine($"ID: {Id} | Name: {Name} | Age: {Age}");
    }
}