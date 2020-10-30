using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF09.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF09.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookContext bookContext = new BookContext();

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return bookContext.Books.ToList();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            Book book = bookContext.Books.FirstOrDefault(e => e.bookID == id);
            return book;

        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            bookContext.Books.Add(book);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}/{newName}")]
        public void Put(int id,Book book)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
