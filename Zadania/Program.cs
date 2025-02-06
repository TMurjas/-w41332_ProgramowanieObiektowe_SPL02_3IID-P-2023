using System.Collections.Generic;

namespace Zadania
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var book1 = new Book("abc", "moja" , 1900 );
            var book2 = new Book("abc", "moja", 1900);
            var book3 = new Book("abc", "moja", 1900);
            var book4 = new Book("abc", "moja", 1900);
            var book5 = new Book("abc", "moja", 1900);
            var book6 = new Book("abc", "moja", 1900);


            book1.ShowInfo();

            var books = new List<Book>() { book1, book2, book3, book4, book5 };

            books.Remove(book1);
            books.Add(book1);
            books.Add(book6);

            void DisplayBooksByAuthror(List<Book> books,string authorsearch)
            {
                foreach (var book in books.Where(x => x.Author == authorsearch))
                {
                    book.ShowInfo();
                }
            }

    void DisplayBookByYear(List<Book> books, int serch)
            {
             foreach (var book in books.Where(x => x.PublickYear == serch))
                {
                 book.ShowInfo();
                }
             }

    void DisplayBooksByTitle(List<Book> books, string serch)
            {
                foreach (var book in books.Where(x => x.Title == serch))
                {
                    book.ShowInfo();
                }
            }

           // DisplayBookByYear(books, 1900);

           // DisplayBooksByAuthror(books, "moja");
            DisplayBooksByTitle(books, "abc");
        }
    }
}
