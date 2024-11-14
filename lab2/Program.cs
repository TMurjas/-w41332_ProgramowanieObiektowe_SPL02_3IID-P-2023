using lab2.my_class;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("klasa Osoba");
            var os = new Osoba("Ola", "strudel", 20, "s33452");
            os.PrzedstawSie();

            Console.WriteLine("klasa licz");
            var moj_licz = new Licz(5);
            moj_licz.displayvalue();
            moj_licz.dodaj(10);
            moj_licz.displayvalue();
            moj_licz.odejmij(2);
            moj_licz.displayvalue();

            Console.WriteLine("klasa sumator");
            var sum = new Sumator(new[] { 6, 4, 3, 3 });
            Console.WriteLine(sum.Sum());
            Console.WriteLine(sum.SumDiv3());
            Console.WriteLine(sum.Count());
            sum.Display(1,2);


        }
    }
}
