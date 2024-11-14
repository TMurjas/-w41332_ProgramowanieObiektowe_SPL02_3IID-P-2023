using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab3.zad2
{
    internal class Osoba
    {
        public string imie{ get; set; }
        public string nazwisko { get; set; }
        public string pesel { get; set; }

        public void ustawImie(string imie)
        {
            this.imie = imie;
        }

        public void ustawNazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

        public void ustawPpesel(string Pesel)
        {
            this.pesel = Pesel;
        }
        public int pobierzWiek()
        {
            var year= int.Parse(pesel.Substring(0,2));
            var month = int.Parse(pesel.Substring(2, 2));
            if (month > 20)
            {
                year += 2000;
            }
            else
            {
                year += 1900;
            }
            return DateTime.Today.Year - year;

        }
        public string pobierzPlec()
        {
            var g = int.Parse(pesel[9].ToString());
            return g % 2 == 0 ? "woman" : "man";
            
        }


        public virtual string pobierzInformacjeOEdukacji() => " ";
   

        public virtual string pobierzPelneImieNazwisko()
        { 
        
        }

        public virtual string czyMozeSamWrocicDoDomu()
        { 
        
        }




    }
}
