﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.myClass
{
    internal class circle (double x): shape(x)
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }

        public override void CalulateArea()
        {
            Console.WriteLine("Circle");
        }
    }
}