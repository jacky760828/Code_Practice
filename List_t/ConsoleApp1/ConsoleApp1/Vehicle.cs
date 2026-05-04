public class Vehicle
{
    public int Speed { get; set; }
    public Vehicle(int speed) => Speed = speed;
    public virtual void DisplayInfo() => Console.WriteLine("Speed: " + Speed);
}

public class Car : Vehicle
{
    public string Model { get; set; }

    public Car(int speed, string model) : base(speed)
    {
        this.Model = model;
    }

    public override void DisplayInfo()
    {
        // 使用 base 調用基類的方法
        base.DisplayInfo();
        Console.WriteLine("Model: " + Model);

    }
}

