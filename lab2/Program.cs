using lab2.my_class;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person os = new();
            user us = new();

            os.Welcome();
            var os3 = Person.mapuser(us);

            os3.Welcome();
            Console.WriteLine($"Hello, World!");
        }
    }
}
