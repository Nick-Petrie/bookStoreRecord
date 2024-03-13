public record Bookstore(int ID, string Title, string Author, double Price);

class Program
{
    static void Main(string[] args)
    {
        Bookstore book1 = new(1, "To Kill a Mockingbird", "Harper Lee", 14.99);
        Bookstore book2 = new(2, "1984", "George Orwell", 12.99);
        Bookstore book3 = new(3, "The Great Gatsby", "F. Scott Fitzgerald", 9.99);
        Console.WriteLine(book1);
        Console.WriteLine(book2);
        Console.WriteLine(book3);
    }
}