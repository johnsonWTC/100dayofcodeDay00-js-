using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Post_2.Models;

namespace Post_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pageViewsController : ControllerBase
    {
        private readonly PostContext _context;

        public pageViewsController(PostContext context)
        {
            _context = context;
        }

        // GET: api/pageViews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pageViews>>> GetpageViews()
        {
            return await _context.pageViews.ToListAsync();
        }

        // GET: api/pageViews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pageViews>> GetpageViews(int id)
        {
            var pageViews = await _context.pageViews.FindAsync(id);

            if (pageViews == null)
            {
                return NotFound();
            }

            return pageViews;
        }

        // PUT: api/pageViews/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}/{numberNumber}")]
        public void PutpageViews(int id, int numberNumber)
        {

            pageViews pageViews = _context.pageViews.FirstOrDefault(e => id == e.ID);
            pageViews.views = numberNumber;
            vi
          

        }
           



        // POST: api/pageViews
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<pageViews>> PostpageViews(pageViews pageViews)
        {
            _context.pageViews.Add(pageViews);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpageViews", new { id = pageViews.ID }, pageViews);
        }

        // DELETE: api/pageViews/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<pageViews>> DeletepageViews(int id)
        {
            var pageViews = await _context.pageViews.FindAsync(id);
            if (pageViews == null)
            {
                return NotFound();
            }

            _context.pageViews.Remove(pageViews);
            await _context.SaveChangesAsync();

            return pageViews;
        }

        private bool pageViewsExists(int id)
        {
            return _context.pageViews.Any(e => e.ID == id);
        }
    }
}
