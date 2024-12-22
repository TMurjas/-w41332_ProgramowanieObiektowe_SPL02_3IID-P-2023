using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab6.zad1.Interface;

namespace Lab6.zad1.Class
{
    public class Book : IDataTwo, IEntity<int>
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }


    }
}
