using System.Xml;

var list = new List<int>();
list.Add(1);

list.AddRange(new int[] { 2, 3, 4 });
Console.WriteLine($"list count: { list.Count} ");

list.Reverse();
Console.WriteLine("list.Reverse()");
Output(list);

//list index
var item = list[2];
Console.WriteLine($"list[2]:{item}");
Console.WriteLine();

var last = list[list.Count - 1];
Console.WriteLine($"last item:{list}");
Console.WriteLine();


void Output(List<int> list)
{
    foreach(int i in list)
    Console.WriteLine($"{i}");
    Console.WriteLine();
    Console.WriteLine();
}




