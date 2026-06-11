namespace ConsoleApp1;

public class Library
{
    public string Name { get; set; }
    public Library(string name) =>  Name = name;
    
    public class Book
    {
        public string Name { get; set; }
        public Book(string name) => Name = name;
    } 
}
