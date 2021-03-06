﻿using System;
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
    public class DepartmentController : ControllerBase
    {
        StudentContext studentContext = new StudentContext();
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return studentContext.Departments.ToList();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Department department)
        {
            studentContext.Departments.Add(department);
            studentContext.SaveChanges();
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
