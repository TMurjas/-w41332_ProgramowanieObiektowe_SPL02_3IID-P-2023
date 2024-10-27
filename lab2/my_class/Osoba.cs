using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.my_class
{
    internal class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        private string pesel;

        public string Imie { get { return imie; } set { imie = value; } }
        public string Nazwisko { get { return nazwisko; } set { nazwisko = value; } }
        public int Wiek { get { return wiek; } set { if (value > 0) wiek = value; else wiek = 0; } }
        public string Pesel => pesel;

        public Osoba(string imie, string nazwisko, int wiek, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.pesel = pesel;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine($"Nazywam się {imie} {nazwisko} i mam {wiek} lat");
        }

        public Osoba()
        { Console.WriteLine("wywolanie konstruktora domysllnego"); }

    }
}
