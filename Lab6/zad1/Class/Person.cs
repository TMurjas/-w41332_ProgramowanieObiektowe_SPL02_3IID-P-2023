using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6.zad1.Interface;

namespace Lab6.zad1.Class
{
    internal class Person : IDataTwo, IEntity<long>
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public Person()
        {
            CreationTime = DateTime.Now;
        }
    }
}
