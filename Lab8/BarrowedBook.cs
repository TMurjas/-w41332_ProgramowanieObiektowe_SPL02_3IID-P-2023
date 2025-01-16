using Lab6.zad1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class BarrowedBook : IEntity<long>, IDataTwo

    {
        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreationTime { get; set; }
    }
}
