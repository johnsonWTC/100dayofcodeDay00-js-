using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF03.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            using (var context = new UserContext()){

                User user = context.Users.FirstOrDefault(e => e.userID == id);
            }
           
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
