using ConsoleApp1;

namespace ZeroToMaster;

internal class Dog : Animal
{
    public string Food {get; set; }

    public Dog()
    {
        Name = "unknown";
        Food = "meat";
    }

    public Dog(string name)
    {
        Name = name;
        Food = "meat";
    }

    public override string Sound()
    {
        return $"{Name} barks.";
    }

    public void Play() => Console.WriteLine($"{Name} plays.");

    // 這個地方會有問題，因為可符合預設參數的方法有多個
    public void Play(string toy="pillar") => Console.WriteLine($"{Name} plays with {toy}.");
    public void Play(int times = 1)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine($"{Name} plays {i + 1} times.");
        }
    }
    public void Play(string toy="ball", int times=2)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine($"{Name} plays with {toy} {i + 1} times.");
        }
    }

    public override string ToString()
    {
        return $"dog {Name} likes {Food}";
    }

    public string Eat() => $"Dog {Name} eats {Food}";
    public void SubscribeFood() => AutoFeeder.FoodMade += FoodNotified;

    public void FoodNotified(object? sender, Foodtype food)
    {
       if(food==Foodtype.Meat)
            Console.WriteLine(Eat());
    }
}
