using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.myClass
{
    internal class shape (double x)
    {
        public double x { get; set; } = x;
        public double y      { get; set; }
        public double width  { get; set; }
        public double height { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Shape");
        }

    }
}
