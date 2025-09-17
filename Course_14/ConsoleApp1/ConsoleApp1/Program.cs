namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            Book book2 = new Book("Jungle Book");

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);
        }
    }
}
