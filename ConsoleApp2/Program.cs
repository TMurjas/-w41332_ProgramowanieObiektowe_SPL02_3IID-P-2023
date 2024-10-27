namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            void LiczbaParzysta()
            {
                Console.WriteLine("Podaj liczbe by sprawdzić czy jest pażysta:");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) { Console.WriteLine("tak"); }
                else { Console.WriteLine("nie"); }
            }


            void WriteEvent()
            { 
                Console.WriteLine("podaj n");
                var n = Console.ReadLine();

                for (var i = 0; i < int.Parse(n); i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            int MojaSilnia(int x)
            {
                if (x == 0) return 1;
                return x*MojaSilnia(x - 1);
            }

            void NapiszGre()
            {
                int mist = 0;
                Random rnd = new Random();
                
                Console.WriteLine("podaj liczbe od 1 do 1000");
                int b = int.Parse(Console.ReadLine());
                int min = 1;
                int max = b;
                int odp = -1;
                
                while (b <= 0)
                {
                Console.WriteLine("błąd!");
                Console.WriteLine("podaj liczbe od 1 do 1000");
                b = int.Parse(Console.ReadLine());
                }

                int nr = rnd.Next(1, b + 1);

                while (true)
                {
                    Console.WriteLine($"zgadnij liczbe od {min} do {max}");
                    odp=int.Parse(Console.ReadLine());
                    if (odp == nr) { mist += 1; break; }
                    else if (odp < nr) { if (odp > min) min = odp; }
                    else if (odp > nr) { if (odp < max) max = odp; }
                    mist += 1;
                }
                if (mist == 1)
                    Console.WriteLine($"Gratulacje wygrałeś! zgadłeś za 1 razem ");
                else if (mist <5)
                    Console.WriteLine($"Gratulacje wygrałeś! zajeło ci to {mist} próby ");
                else
                    Console.WriteLine($"Gratulacje wygrałeś! zajeło ci to {mist} prób ");
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
                    case 3:
                        Console.WriteLine("podaj nr silni");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine(MojaSilnia(x));
                    break;
                    case 4: NapiszGre();  break;
                    default: break;

                }

                if (opcja == 5)
                    break;




            }



          
        }
    }
}
