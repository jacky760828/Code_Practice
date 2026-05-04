namespace ZeroToMaster;

internal class Sheep : Animal
{
    public string Food {get; set; }

    public Sheep()
    {
        Name = "unknown";
        Food = "meat";
    }

    public Sheep(string name)
    {
        Name = name;
        Food = "meat";
    }

    public override string Sound()
    {
        return $"{Name} baas.";
    }
}
