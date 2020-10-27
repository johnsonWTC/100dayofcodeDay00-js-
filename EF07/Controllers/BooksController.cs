using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF07.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF07.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        BookContext bookContext = new BookContext();
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return bookContext.Books.ToList();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            Book book = bookContext.Books.FirstOrDefault(e => e.bookID == id);
            return book;
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            bookContext.Books.Add(book);
            bookContext.SaveChanges();
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}/{newName}")]
        public void Put(int id,  string newName)
        {
            Book book = bookContext.Books.FirstOrDefault(e => e.bookID == id);
            book.BookName = newName;
            bookContext.SaveChanges();

        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Book book = bookContext.Books.FirstOrDefault(e => e.bookID == id);
            bookContext.Remove(book);
            bookContext.SaveChanges();
        }
    }
}
