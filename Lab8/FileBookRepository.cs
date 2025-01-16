using Lab6.zad1.Class;
using Lab6.zad1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class FileBookRepository : IBookRepository
    {

        private readonly string _fileName = "books.jason";

        private List<Book> readfile()
        {
            if (File.Exists(_fileName))
            {
            var content = File.ReadAllText(_fileName);
                    
            }

        }




        public void Create(Book entity)
        {
            throw new NotImplementedException();
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

        public void save(Book entity)
        {
            throw new NotImplementedException();
        }

        public void load(Book entity)
        {
            throw new NotImplementedException();
        }


    }
}
