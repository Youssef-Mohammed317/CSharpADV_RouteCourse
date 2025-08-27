using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate string fPtr(Book book);
    public static class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, fPtr del)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(del.Invoke(book));
            }
        }
        public static void ProcessBooks2(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (Book b in books)
            {
                Console.WriteLine(fPtr(b));
            }
        }

        public static void GetISBN(List<Book> books)
        {
            //Func<Book, string> fPtr = delegate (Book b) { return b.ISBN; };
            //Func<Book, string> fPtr = b => b.ISBN;
            Func<Book, string> fPtr = b => BookFunctions.GetISBN(b);

            ProcessBooks(books, fPtr);
        }
        public static void GetPublicationDate(List<Book> books)
        {
            //Func<Book, string> fPtr = delegate (Book b) { return b.PublicationDate.ToString(); };
            //Func<Book, string> fPtr = b => b.PublicationDate.ToString();
            Func<Book, string> fPtr = b => BookFunctions.GetPublicationDate(b);

            ProcessBooks(books, fPtr);
        }
    }
}
