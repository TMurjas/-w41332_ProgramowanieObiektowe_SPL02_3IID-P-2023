using Lab6.zad1.Class;
using Lab6.zad1.Interface;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class ADONETBookRepository(Iconfiguration configuration) : IBookRepository
    {


        public void Create(Book entity)
        {
            using var connection = new SQLiteConnection();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
