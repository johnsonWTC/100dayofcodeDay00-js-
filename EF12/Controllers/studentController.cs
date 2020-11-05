using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF12.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentController : ControllerBase
    {
        // GET: api/<studentController>



        StudentContext studentContext = new StudentContext();
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return studentContext.Students.ToList();
        }

        // GET api/<studentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            Student student = studentContext.Students.FirstOrDefault(e => e.studentID == id);
           
            return student;
        }

        // POST api/<studentController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            studentContext.Students.Add(student);
            studentContext.SaveChanges();
        }

        // PUT api/<studentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<studentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
