
namespace ConsoleApp1;

public class Sheep:Animal
{
    //資料成員
    //private string Name; //欄位
    public string Food { get; set; } //屬性
                                     //屬性不能設置為readonly;此時只能取值不能設值

    //建構子
    public Sheep()
    {
        Name ="unknown";
        Food = "meat";
    }
    public Sheep(string name)
    {
        Name = name;
        Food = "meat";
        
    }


    //方法成員
    public override string Sound() => ($"{Name} 咩咩咩.");



}
