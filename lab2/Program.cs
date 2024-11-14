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

            var sum = new Sumator(new[] { 6, 4, 3, 2 });

            sum.Display(1,2);

        }
    }
}
