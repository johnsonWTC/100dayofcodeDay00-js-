using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EF13.Models;

namespace EF13.Controllers
{
    public class RoomNumbersController : Controller
    {
        private readonly StudentContext _context;

        public RoomNumbersController(StudentContext context)
        {
            _context = context;
        }

        // GET: RoomNumbers
        public async Task<IActionResult> Index()
        {
            return View(await _context.roomNumbers.ToListAsync());
        }

        // GET: RoomNumbers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomNumber = await _context.roomNumbers
                .FirstOrDefaultAsync(m => m.roomNumberID == id);
            if (roomNumber == null)
            {
                return NotFound();
            }

            return View(roomNumber);
        }

        // GET: RoomNumbers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomNumbers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("roomNumberID,roomName")] RoomNumber roomNumber)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomNumber);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomNumber);
        }

        // GET: RoomNumbers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomNumber = await _context.roomNumbers.FindAsync(id);
            if (roomNumber == null)
            {
                return NotFound();
            }
            return View(roomNumber);
        }

        // POST: RoomNumbers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("roomNumberID,roomName")] RoomNumber roomNumber)
        {
            if (id != roomNumber.roomNumberID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomNumber);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomNumberExists(roomNumber.roomNumberID))
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
            return View(roomNumber);
        }

        // GET: RoomNumbers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomNumber = await _context.roomNumbers
                .FirstOrDefaultAsync(m => m.roomNumberID == id);
            if (roomNumber == null)
            {
                return NotFound();
            }

            return View(roomNumber);
        }

        // POST: RoomNumbers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomNumber = await _context.roomNumbers.FindAsync(id);
            _context.roomNumbers.Remove(roomNumber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomNumberExists(int id)
        {
            return _context.roomNumbers.Any(e => e.roomNumberID == id);
        }
    }
}
