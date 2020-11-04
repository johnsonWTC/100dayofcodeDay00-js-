using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WAPI12.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WAPI12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FucultyController : ControllerBase
    {
        // GET: api/<FucultyController>

        StudentContext _context = new StudentContext();
        [HttpGet]
        public IEnumerable<Faculty> Get()
        {
            return _context.faculties.ToList();
        }

        // GET api/<FucultyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FucultyController>
        [HttpPost]
        public void Post([FromBody] Faculty faculty)
        {
            _context.faculties.Add(faculty);
            _context.SaveChanges();
        }

        // PUT api/<FucultyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FucultyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
