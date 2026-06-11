//====== 區域函數寫法 ======
//void YearInfo(int year)
//{
//    if(IsLeapYear(year))
//        Console.WriteLine($"{year}是 閏年");
//    else
//        Console.WriteLine($"{year}不是閏年");

//    bool IsLeapYear(int year)
//    {
//        if (year % 100 == 0) return year % 400 == 0;
//        return year % 4 == 0;
//    }
//}

//var years = new int[] { 1900, 2000, 2019, 2020 };
//foreach(var year in years)
//{
//    YearInfo(year);
//}
//Console.WriteLine();

//====== this和base用法 =======

//using ConsoleApp1;
//var car1 = new Car(110, "Honda");
//car1.DisplayInfo();
//car1.Register();
//Console.WriteLine();
//var car2 = new Car(99, "Benz");
//car2.DisplayInfo();
//car2.Register();

//===== 主要建構子 =====

using ConsoleApp1;

var p1 = new Person("Mary",20);
var p2 = new Person("Lary", "Lee", 18);

