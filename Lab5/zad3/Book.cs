using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.zad3
{
    internal class Book:IDataTwo, IEntity<int>
    {
        public int Id { get; set; }
        public DateTime Now { get; set; }


    }
}
