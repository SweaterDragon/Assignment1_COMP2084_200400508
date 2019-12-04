using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment1_COMP2084_200400508.Data;
using Assignment1_COMP2084_200400508.Models;
using Microsoft.AspNetCore.Authorization;

namespace Assignment1_COMP2084_200400508.Controllers
{
    public class TomesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TomesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tomes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tome.ToListAsync());
        }

        // GET: Tomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tome = await _context.Tome
                .FirstOrDefaultAsync(m => m.TomeId == id);
            if (tome == null)
            {
                return NotFound();
            }

            return View(tome);
        }

        // GET: Tomes/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tomes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TomeId,Name,Pages,Description,IsRented")] Tome tome)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tome);
        }

        // GET: Tomes/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tome = await _context.Tome.FindAsync(id);
            if (tome == null)
            {
                return NotFound();
            }
            return View(tome);
        }

        // POST: Tomes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TomeId,Name,Pages,Description,IsRented")] Tome tome)
        {
            if (id != tome.TomeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tome);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TomeExists(tome.TomeId))
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
            return View(tome);
        }

        // GET: Tomes/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tome = await _context.Tome
                .FirstOrDefaultAsync(m => m.TomeId == id);
            if (tome == null)
            {
                return NotFound();
            }

            return View(tome);
        }

        // POST: Tomes/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tome = await _context.Tome.FindAsync(id);
            _context.Tome.Remove(tome);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TomeExists(int id)
        {
            return _context.Tome.Any(e => e.TomeId == id);
        }
    }
}
