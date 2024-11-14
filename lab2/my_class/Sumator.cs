using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab2.my_class
{
    internal class Sumator(int[] num)
    {
        private int[] numbers = num;

        public int Sum() { return numbers.Sum(); }
        public double SumDiv3() { return numbers.Sum(x=>x/3); }
        public int Count() { return numbers.Count(); }
        public void Display(int low, int high)
        {
            if (low < 0)
                low = 0;
            if (high >numbers.Length-1)
                high = numbers.Length-1;

            for (int i = low; i <= high; i++)
            { 
            Console.WriteLine(numbers[i]);
            }
        
        }


    }
}
