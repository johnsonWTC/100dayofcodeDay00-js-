﻿using System;
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
    public class PostsAPIController : ControllerBase
    {
        private readonly PostContext _context;

        public PostsAPIController(PostContext context)
        {
            _context = context;
        }

        // GET: api/PostsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            var postContext = _context.Posts.Include(c => c.comments);
            return await postContext.ToListAsync();
        }

        // GET: api/PostsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        // PUT: api/PostsAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(int id, Post post)
        {
            if (id != post.postID)
            {
                return BadRequest();
            }

            _context.Entry(post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(id))
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

        // POST: api/PostsAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPost", new { id = post.postID }, post);
        }

        // DELETE: api/PostsAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Post>> DeletePost(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return post;
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.postID == id);
        }

        [HttpPost("{postID}/{likeID}")]
        public async Task<ActionResult<int>> PostLikes(int postID)
        {
            var post = await _context.Posts.FindAsync(postID);
            if (post == null)
            {
                return NotFound();
            }
            post.postLike = post.postLike + 1;

            await _context.SaveChangesAsync();

            return postID;
        }

        [HttpPost("{postID}/{likeID}/{postViews}")]
        public async Task<ActionResult<int>> PostViews(int postID)
        {
            var post = await _context.Posts.FindAsync(postID);
            if (post == null)
            {
                return NotFound();
            }
            post.numberofviews = post.numberofviews + 1;

            await _context.SaveChangesAsync();

            return postID;
        }
    }
}
