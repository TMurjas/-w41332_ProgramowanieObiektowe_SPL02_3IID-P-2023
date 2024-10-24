namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            void LiczbaParzysta()
            {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            { Console.WriteLine("tak"); }
            else
            { Console.WriteLine("nie"); }
            }


            void WriteEvent()
            { 
            Console.WriteLine("podaj n");
            var n = Console.ReadLine();
            //var abc= 10;
            //Console.WriteLine($"Hello, World {abc}");
             for (var i = 0; i < int.Parse(n); i += 2)
             {
                 Console.WriteLine(i);
             }
            }

            int MojaSilnia(int x)
            {
                if (x == 0) return 1;
                return MojaSilnia(x - 1);
            }


            while(true)
            {
                Console.WriteLine("wybierz");
                Console.WriteLine("1. liczba parzsta");
                Console.WriteLine("2. wypisz liczby");
                Console.WriteLine("3. silnia");
                Console.WriteLine("4. gra");
                Console.WriteLine("5.wyjscie");
                int opcja = int.Parse(Console.ReadLine());

                switch (opcja)
                {
                    case 1: LiczbaParzysta(); break;
                    case 2: WriteEvent(); break;
                    case 3: break;
                    default: break;

                }

                if (opcja == 5)
                    break;




            }



          
        }
    }
}
