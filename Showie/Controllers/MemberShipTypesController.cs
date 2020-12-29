﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Showie.Data;
using Showie.Models;

namespace Showie.Controllers
{
    public class MemberShipTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MemberShipTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MemberShipTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.memberShipTypes.ToListAsync());
        }

        // GET: MemberShipTypes/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberShipType = await _context.memberShipTypes
                .FirstOrDefaultAsync(m => m.id == id);
            if (memberShipType == null)
            {
                return NotFound();
            }

            return View(memberShipType);
        }

        // GET: MemberShipTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MemberShipTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,SignUpFee,DurationInMonths,DiscountInRate")] MemberShipType memberShipType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memberShipType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(memberShipType);
        }

        // GET: MemberShipTypes/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberShipType = await _context.memberShipTypes.FindAsync(id);
            if (memberShipType == null)
            {
                return NotFound();
            }
            return View(memberShipType);
        }

        // POST: MemberShipTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("id,SignUpFee,DurationInMonths,DiscountInRate")] MemberShipType memberShipType)
        {
            if (id != memberShipType.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memberShipType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberShipTypeExists(memberShipType.id))
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
            return View(memberShipType);
        }

        // GET: MemberShipTypes/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberShipType = await _context.memberShipTypes
                .FirstOrDefaultAsync(m => m.id == id);
            if (memberShipType == null)
            {
                return NotFound();
            }

            return View(memberShipType);
        }

        // POST: MemberShipTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var memberShipType = await _context.memberShipTypes.FindAsync(id);
            _context.memberShipTypes.Remove(memberShipType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberShipTypeExists(short id)
        {
            return _context.memberShipTypes.Any(e => e.id == id);
        }
    }
}
