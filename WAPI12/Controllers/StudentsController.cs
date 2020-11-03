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
    public class StudentsController : ControllerBase
    {
        // GET: api/<StudentsController>

        StudentContext _context = new StudentContext();
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.students.ToList();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            Student student = _context.students.FirstOrDefault(e => e.studentID == id);
            return student;
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _context.students.Add(student);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}/{newName}")]
        public void Put(int id, string newName)
        {
            Student student = _context.students.FirstOrDefault(e => e.studentID == id);
            student.studentName = newName;
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
