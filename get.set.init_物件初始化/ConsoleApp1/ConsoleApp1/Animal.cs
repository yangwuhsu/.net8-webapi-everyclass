namespace ConsoleApp1;

public class Animal
{
    public string Name { get; set; }
    public virtual string Sound() => "@#jdio";
    protected virtual string Eat() => "Eating";


}
