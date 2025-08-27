namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = [
                new Book("12345", "C# in Depth", new string[] { "Jon Skeet" }, new DateTime(2019, 3, 23), 50m),
                new Book("67890", "CLR via C#", [ "Jeffrey Richter", "John Smath" ], new DateTime(2012, 2, 14), 60m),
                new Book("54321", "Pro ASP.NET Core MVC", new string[] { "Adam Freeman" }, new DateTime(2020, 6, 10), 70m)
            ];

            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

            LibraryEngine.GetISBN(books);

            LibraryEngine.GetPublicationDate(books);

        }
    }
}
