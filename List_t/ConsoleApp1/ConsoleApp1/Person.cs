namespace ZeroToMaster;

// 待改寫, 使用 primary constructor
public class Person
{
    public string Name { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }

    public Person()
    {
        Name = "John";
        Age = 25;
    }

    public Person(string name)
    {
        Name = name;
        Age = 25;
    }

    public Person(string name, string lastName, int age=25)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
