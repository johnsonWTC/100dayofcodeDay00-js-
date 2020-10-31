using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF10.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        // GET: api/<DepartmentController>

        SchoolContext _context = new SchoolContext();

        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return _context.departments.ToList();
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public Department Get(int id)
        {
            Department department = _context.departments.FirstOrDefault(e => e.departmentID == id);
            return department;
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
