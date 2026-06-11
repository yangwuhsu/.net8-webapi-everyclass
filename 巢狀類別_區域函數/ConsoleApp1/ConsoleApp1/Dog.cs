
namespace ConsoleApp1;

public class Dog:Animal
{
    //資料成員
    //private string Name; //欄位
    public string Food { get; set; } //屬性
                                     //屬性不能設置為readonly;此時只能取值不能設值

    //建構子
    public Dog()
    {
        Name ="unknown";
        Food = "meat";
    }
    public Dog(string name)
    {
        Name = name;
        Food = "meat";
        
    }


    //方法成員
    public override string Sound()
    {
        return($"{Name} 旺旺旺.");
    }
    //public string Play()
    //{
    //    return $"{Name} dog play";
    //}

    //多載overloading
    //根據我傳什麼參數會呼叫哪一個play:參數必須不同
    public string Play() => $"{Name} playing";
    public string Play(string toy) => $"{Name} play {toy}";
    public void Play(int times)
    {
        for(int i = 0; i < times; i++)
        {
            Console.WriteLine($"{Name} play {i+1} times");
        }
    }

}
