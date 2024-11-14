using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab3.zad2
{
    internal class Nauczyciel:Osoba
    {
        public string tytulNaukowy {  get; set; }
        public string uczniowieKlasy { get; set; }

        public void dodajUcznia(Uczen uczen)
        { }
        public void ktorzyUcziowieMogaWrocicSamodzielnie()
        { }
        public void podsumowanieKlasy(DateTime date)
        {
            Console.WriteLine(date.DayOfWeek);
        
        
        }


    }
}
