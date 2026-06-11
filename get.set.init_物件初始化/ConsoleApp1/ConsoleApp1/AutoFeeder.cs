

namespace ConsoleApp1;
//靜態類別介紹
//所有成員都必須是靜態的
public static class AutoFeeder
{
    private static Random Rnd = new Random();
    private static string[] _foods = new string[] { "meat", "fish", "grass" };

    public static string MakeFood()
    {
        int index = Rnd.Next(_foods.Length);
        return _foods[index];
    }
    public static string Do => "123";
}
