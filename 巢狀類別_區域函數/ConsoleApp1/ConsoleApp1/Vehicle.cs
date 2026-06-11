using System.Runtime.CompilerServices;

namespace ConsoleApp1;

public class Vehicle
{
    public int Speed { get; set; }
    public Vehicle(int speed) => Speed = speed;
    public virtual void DisplayInfo() => Console.WriteLine($"speed:{Speed}");
}
public static class CarCenter
{
    public static void Register(Car car) => Console.WriteLine($"{car.Model} 已註冊");
}

public class Car : Vehicle
{
    public string Model { get; set; }
    public Car(int speed,string model):base(speed)
    {
        Model = model;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"model:{Model}");
    }
    public void Register() => CarCenter.Register(this);
}
