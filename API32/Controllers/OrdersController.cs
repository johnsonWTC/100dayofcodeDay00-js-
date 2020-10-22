using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API29.Data;
using API32.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API32.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        
        public static List<Product> products = new List<Product>();


       // using ( var _context = new Context());
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            using (var _context = new Context()) 

            return products;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            using (var _context = new Context()) ;
            products.Add(product);

        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
