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
    public class commentsAPIController : ControllerBase
    {
        private readonly PostContext _context;

        public commentsAPIController(PostContext context)
        {
            _context = context;
        }

        // GET: api/commentsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<comment>>> Getcomments()
        {
            return await _context.comments.ToListAsync();
        }

        // GET: api/commentsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<comment>> Getcomment(int id)
        {
            var comment = await _context.comments.FindAsync(id);

            if (comment == null)
            {
                return NotFound();
            }

            return comment;
        }

        // PUT: api/commentsAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcomment(int id, comment comment)
        {
            if (id != comment.commentID)
            {
                return BadRequest();
            }

            _context.Entry(comment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!commentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/commentsAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<comment>> Postcomment(comment comment)
        {
            _context.comments.Add(comment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcomment", new { id = comment.commentID }, comment);
        }

        // DELETE: api/commentsAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<comment>> Deletecomment(int id)
        {
            var comment = await _context.comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            _context.comments.Remove(comment);
            await _context.SaveChangesAsync();

            return comment;
        }

        private bool commentExists(int id)
        {
            return _context.comments.Any(e => e.commentID == id);
        }


        [HttpPut("{id}")]
        public int  Putcomment(int id)
        {
            var comment = _context.comments.FirstOrDefault(e => e.commentID == id);
            comment.commentLikes = comment.commentLikes++;
            return comment.commentLikes;
        }
    }
}
