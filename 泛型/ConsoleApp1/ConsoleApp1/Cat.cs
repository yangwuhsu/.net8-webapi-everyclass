
namespace ConsoleApp1;

public class Cat:Animal
{
    //資料成員
    //private string Name; //欄位
    public int Age;
    public string Food { get; init; } 
    private static int _count = 0;
    public static int ReadCount;

    public static int Count
    {
        get
        {
            ReadCount++;
            return _count;
        }
        set => _count = value;
    }        
    public static int DoCount() => Count;

    //建構子
    public Cat()
    {
        Name ="unknown";
        Food = "fish";
        Count++;
    }
    public Cat(string name)
    {
        Name = name;
        Food = "meat";
        Count++;
        
    }


    //方法成員
    public override string Sound() => ($"{Name} 喵喵喵.");

    public int CatCount() => Count;
}

