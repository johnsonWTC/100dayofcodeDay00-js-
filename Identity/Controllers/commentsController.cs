using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Identity.Models;

namespace Identity.Controllers
{
    public class commentsController : Controller
    {
        private readonly IdentityContext _context;

        public commentsController(IdentityContext context)
        {
            _context = context;
        }

        // GET: comments
        public async Task<IActionResult> Index()
        {
            var identityContext = _context.comments.Include(c => c.User).Include(c => c.post);
            return View(await identityContext.ToListAsync());
        }

        // GET: comments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.comments
                .Include(c => c.User)
                .Include(c => c.post)
                .FirstOrDefaultAsync(m => m.commentID == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: comments/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["postID"] = new SelectList(_context.Posts, "postID", "postID");
            return View();
        }

        // POST: comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("commentID,commentContent,commentLikes,commentViews,postID,UserId")] comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", comment.UserId);
            ViewData["postID"] = new SelectList(_context.Posts, "postID", "postID", comment.postID);
            return View(comment);
        }

        // GET: comments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", comment.UserId);
            ViewData["postID"] = new SelectList(_context.Posts, "postID", "postID", comment.postID);
            return View(comment);
        }

        // POST: comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("commentID,commentContent,commentLikes,commentViews,postID,UserId")] comment comment)
        {
            if (id != comment.commentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!commentExists(comment.commentID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", comment.UserId);
            ViewData["postID"] = new SelectList(_context.Posts, "postID", "postID", comment.postID);
            return View(comment);
        }

        // GET: comments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.comments
                .Include(c => c.User)
                .Include(c => c.post)
                .FirstOrDefaultAsync(m => m.commentID == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _context.comments.FindAsync(id);
            _context.comments.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool commentExists(int id)
        {
            return _context.comments.Any(e => e.commentID == id);
        }
    }
}
