using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    internal class Book (string title,string author,int publishYear)
    {
        private string author = author;
        private string title = title;
        private int publishYear = publishYear;


 

        public string Title { get { return this.title; } set { this.title = value; } }

        public string Author { get { return this.author; } set { this.author = value; } }

        public int PublickYear { get { return this.publishYear; } set { this.publishYear = value; } }

        public string GetAuthro()
        {
            return this.author;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{title} - {author} {publishYear}");
        }

    }
}
