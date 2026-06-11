
namespace ConsoleApp1;

public class Cat:Animal
{
    //資料成員
    //private string Name; //欄位
    public string Food { get; set; } //屬性
                                     //屬性不能設置為readonly;此時只能取值不能設值
    public static int Count { get; set; }
    public static int DoCount() => Count;

    //public int Count { get; set; }
    //public int DoCount() => Count;    

    //建構子
    public Cat()
    {
        Name ="unknown";
        Food = "meat";
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

