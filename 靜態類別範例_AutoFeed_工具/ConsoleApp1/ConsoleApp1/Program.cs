using ConsoleApp1;

////var p1 = new Point(2, 2);
////var p2 = new Point(10, 10);
////var p3 = p1 + p2;

////Console.WriteLine($"{p1} + {p2} = {p3}");

////var p4 = p2 - p1;
////Console.WriteLine($"{p2} - {p1}={p4}");
////Console.WriteLine();
////Console.WriteLine($"{p1}=={p2}:{p1==p2}");

//var cat1 = new Cat("kitty");
//var cat2 = new Cat("Halllo");
//var cat3 = new Cat("Amy");
////Console.WriteLine(cat1.Count);
//Console.WriteLine(Cat.Count);
//Console.WriteLine(Cat.DoCount());
//Console.WriteLine(cat1.CatCount());


var dog = new Dog("Max");
var cat = new Cat("Kitty");
var sheep = new Sheep("Mary");

while (true)
{

    var food = AutoFeeder.MakeFood();

    switch (food)
    {
        case "meat":
            //型別,方法,這就是靜態類別(Console),因為Console只有一個
            Console.WriteLine($"dog {dog.Name} eats. ");
            break;
        case "fish":
            Console.WriteLine($"cat {cat.Name} eats. ");
            break;
        case "grass":
            Console.WriteLine($"sheep {sheep.Name} eats. ");
            break;
        default:
            Console.WriteLine("No one eat.");
            break;
    }
    Console.WriteLine("Press enter...");
    Console.ReadLine();
}

