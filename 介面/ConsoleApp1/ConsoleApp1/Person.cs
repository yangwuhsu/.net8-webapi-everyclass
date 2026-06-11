namespace ConsoleApp1;

//主要建構子寫法
public class Person(string name,int age)
{
    public string Name { get; set; } = name;
    public string LastName { get; set; } = "";
    public int Age { get; set; } = age;

    //使用了主要建構子必須依賴該參數
    public Person(string name,string lastName,int age =25):this(name,age)
    {
        //Name = name;
        LastName = lastName;
        //Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{Name},{LastName},{Age}");
    }
}
