namespace ZeroToMaster;

internal class Animal
{
    public string Name { get; set; } = "";

    public virtual string Sound()
    {
        return "@#$%";
    }

    public virtual string Eat()
    {
       return "Eating";
       //return $"Dog {Name}  eats {Food}";
    }
}
