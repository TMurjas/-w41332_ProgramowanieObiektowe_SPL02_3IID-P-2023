using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab6.zad1;
using Lab6.zad1.Class;
using Lab6.zad1.Interface;


namespace WebApplication1.Controllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookRepository reposytory;

        public BookController()
        {
            reposytory = new BookRepository ();
        }


        [HttpGet]
        public List<Book> GetAll()
        {
            return reposytory.GetAll();
        }

        [HttpPost]
        public bool PostList(Book book)
        {
            reposytory.Create(book);
            return true;
        }


    }
}
