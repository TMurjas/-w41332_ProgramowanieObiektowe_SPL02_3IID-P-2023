using Lab6.zad1.Class;
using Lab6.zad1.Interface;

namespace Lab6.zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookRepository bookRepository = new BookRepository();

            foreach (var book in bookRepository.GetAll())
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
