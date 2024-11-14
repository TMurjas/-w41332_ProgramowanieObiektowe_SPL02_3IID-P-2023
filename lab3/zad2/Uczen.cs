using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.zad2
{
    internal class Uczen:Osoba
    {
        public string nazwaSzkoly {  get; set; }
        public bool mozeSamWrocicDoDomu { get; set; }

        public void ustawSzkole(string nazwaSzkoly)
        {
            this.nazwaSzkoly = nazwaSzkoly;
        }
        public void zmienSzkole(string nazwaSzkoly)
        {
            this.nazwaSzkoly = nazwaSzkoly;
        }
        public void ustawCzyMozeSamWrocic(bool mozeSamWrocicDoDomu)
        {
        
        }
        public void informacja()
        { }
        public override void pobierzInformacjeOEdukacji()
        { }
        public override void czyMozeSamWrocicDoDomu()
        { }
    }
}
