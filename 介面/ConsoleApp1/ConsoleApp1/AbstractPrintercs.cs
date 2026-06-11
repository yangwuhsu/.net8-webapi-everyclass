namespace ConsoleApp1;

//public abstract class AbstractPrinter
public abstract class AbstractPrintercs
{
    public string PrinerType { get; set; } = "Abstract Printer";
    public abstract void Print(string message);
}

public class DotPrinter : AbstractPrintercs
{
    public DotPrinter()
    {
        PrinerType = "Dot Printer";
    }
    public override void Print(string message)
    {
        Console.WriteLine("Dot :{0}",message);
    }
}
public class LaserPrinter : AbstractPrintercs
{
    public LaserPrinter()
    {
        PrinerType = "Laser Printer";
    }
    public override void Print(string message)
    {
        Console.WriteLine("Laser:{0}",message);
    }
}