using ConsoleApp1;



var cat1 = new Cat("Kitty");
var cat2 = new Cat("Tom");
var cat3 = new Cat("Marry");
//物件初始化
var cat4 = new Cat() { Name = "Alice", Food = "honey",Age=2 };
Console.WriteLine($"cat4: {cat4.Name},food:{cat4.Food},Age:{cat4.Age}");


//Console.WriteLine(Cat.Count);
//Console.WriteLine(Cat.DoCount());
//Console.WriteLine(cat1.CatCount());

//Console.WriteLine($"Cat's Count is {Cat.ReadCount} times");
//Console.WriteLine("----------------------");




//Console.WriteLine($"--- 初始狀態 ---");
//Console.WriteLine($"貓咪總數: {Cat.Count}");      // 這會觸發一次 get
//Console.WriteLine($"查詢次數: {Cat.ReadCount}");

//Console.WriteLine($"\n--- 建立兩隻貓 ---");
//var cat1 = new Cat("小黑"); // 建構子內有 Count++ (觸發 get 和 set)
//var cat2 = new Cat("咪咪"); // 建構子內有 Count++ (觸發 get 和 set)

//Console.WriteLine($"\n--- 最終結算 ---");
//Console.WriteLine($"貓咪總數: {Cat.Count}");      // 又觸發一次 get
//Console.WriteLine($"查詢次數: {Cat.ReadCount}");