using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API01.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        MyDbContext _context;
        public UserController()
        {
           
           _context = new MyDbContext();
        }


        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            
            if(_context.Users.Count()  == 0)
            {
                User defaultUser = new User();
                defaultUser.userName = "defultsUser";
                defaultUser.userID = 0;
                _context.Users.Add(defaultUser);
            }
          
            return _context.Users.ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {

            User user = (_context.Users.FirstOrDefault(c => c.userID == id));
            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            
            _context.Users.Add(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
