using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF06.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF06.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        BookContext _context = new BookContext();
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Books> Get()
        {
            return _context.Books.ToList();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Books Get(int id)
        {
            Books book = _context.Books.FirstOrDefault(e => e.booksID == id);
            return book;
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Books   book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}/{newName}")]
        public void Put(int id, string newName)
        {
            Books book = _context.Books.FirstOrDefault(e => e.booksID == id);
            book.BookName = newName;
            _context.SaveChanges();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Books book = _context.Books.FirstOrDefault(e => e.booksID == id);
            _context.Remove(book);
            _context.SaveChanges();
        }
    }
}
