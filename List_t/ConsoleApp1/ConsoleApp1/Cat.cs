using ConsoleApp1;

namespace ZeroToMaster;

internal class Cat : Animal
{
    public string Food {get; set; }
    public static int Count {get; set; }

    public static int DoCount() => Count;

    // public static string GetName() => Name;  // static 方法不能存取物件成員

    public Cat()
    {
        Name = "unknown";
        Food = "meat";
        Count++;
    }

    public Cat(string name)
    {
        Name = name;
        Food = "meat";
        Count++;
    }
    public override string Eat()
    {
        return $"Cat {Name} eats fish";
    }
    public override string Sound()
    {
        return $"{Name} meows.";
    }
    public void SubscribeFood() => AutoFeeder.FoodMade += FoodNotified;

    public void FoodNotified(object? sender, Foodtype food)
    {
       if(food==Foodtype.Fish)
            Console.WriteLine(Eat());
    }
}
