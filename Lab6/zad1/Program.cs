using Lab6.zad1.Class;
using Lab6.zad1.Interface;

namespace Lab6.zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookRepository bookRepository = new BookRepository();

            bookRepository.Create(new Book
            {
                Id = 1,
                CreationTime = DateTime.Now,
                Title = "Potop"
            });

            bookRepository.Create(new Book
            {
                Id = 1,
                CreationTime = DateTime.Now,
                Title = "ABC"
            });

            bookRepository.Delete(1);
            

            foreach (var book in bookRepository.GetAll())
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
