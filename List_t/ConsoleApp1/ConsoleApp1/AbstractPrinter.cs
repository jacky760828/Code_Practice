namespace ZeroToMaster;

// 抽象類別, 不能被實體化
public abstract class AbstractPrinter
{
    public string PrinterType { get; set; } = "Abstract Printer";
    public abstract void Print(string message);

    // 可以有非抽象方法或是 virtual 方法
}

public sealed class DotPrinter : AbstractPrinter
{
    public DotPrinter()
    {
        PrinterType = "Dot Printer";
    }

    public override void Print(string message)
    {
        Console.WriteLine("Dot: {0}", message);
    }
}


public class LaserPrinter : AbstractPrinter
{
    public LaserPrinter()
    {
        PrinterType = "Laser Printer";
    }

    public override void Print(string message)
    {
        Console.WriteLine("Laser: {0}", message);
    }
}   

