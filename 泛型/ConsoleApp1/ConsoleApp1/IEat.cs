namespace ConsoleApp1;

interface IEat
{
    string FavoriteFood { get; set; }
    string Eat();
    string Move(string way="east",int moves=1);

}
