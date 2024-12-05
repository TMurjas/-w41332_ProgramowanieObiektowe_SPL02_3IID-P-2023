using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.myClass
{
    internal class rectangle(double x) : shape(x)
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
        public override void CalulateArea()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
