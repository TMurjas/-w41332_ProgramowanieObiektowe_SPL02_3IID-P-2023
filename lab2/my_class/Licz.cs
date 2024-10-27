using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab2.my_class
{
    internal class Licz (double val)
    {
        private double value = val;


        public void dodaj(double value)
        {
            this.value += value;
        }

        public void odejmij(double value)
        {
            this.value -= value;
        }

        public void displayvalue()
        {
            Console.WriteLine(value);
        }

    }
}
