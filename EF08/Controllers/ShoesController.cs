﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF08.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF08.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController : ControllerBase
    {

        ShoeContext _context = new ShoeContext();
        // GET: api/<ShoesController>
        [HttpGet]
        public IEnumerable<Shoe> Get()
        {
            return _context.shoes.ToList();
        }

        // GET api/<ShoesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShoesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShoesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShoesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
