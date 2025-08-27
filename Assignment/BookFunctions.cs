using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public static class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }
        public static string GetAuthors(Book book)
        {
            return string.Join(", ", book.Authors);
        }
        public static string GetPrice(Book book)
        {
            return book.Price.ToString();
        }

        public static string GetISBN(Book book) => book.ISBN;

        public static string GetPublicationDate(Book book) => book.PublicationDate.ToShortDateString();

    }
}
