using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAPITandemMixer.Context;
using WebAPITandemMixer.Models;

namespace WebAPITandemMixer.Controllers
{
    public class PhasesController : Controller
    {
        private readonly AppDbContext _context;

        public PhasesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Phases
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Phases.Include(p => p.PhaseTypeNavigation);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Phases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Phases == null)
            {
                return NotFound();
            }

            var phase = await _context.Phases
                .Include(p => p.PhaseTypeNavigation)
                .FirstOrDefaultAsync(m => m.PhaseId == id);
            if (phase == null)
            {
                return NotFound();
            }

            return View(phase);
        }

        // GET: Phases/Create
        public IActionResult Create()
        {
            ViewData["PhaseType"] = new SelectList(_context.PhaseTypes, "PhaseType1", "PhaseType1");
            return View();
        }

        // POST: Phases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhaseId,CompoundName,Stage,Phase1,PhaseType")] Phase phase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PhaseType"] = new SelectList(_context.PhaseTypes, "PhaseType1", "PhaseType1", phase.PhaseType);
            return View(phase);
        }

        // GET: Phases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Phases == null)
            {
                return NotFound();
            }

            var phase = await _context.Phases.FindAsync(id);
            if (phase == null)
            {
                return NotFound();
            }
            ViewData["PhaseType"] = new SelectList(_context.PhaseTypes, "PhaseType1", "PhaseType1", phase.PhaseType);
            return View(phase);
        }

        // POST: Phases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhaseId,CompoundName,Stage,Phase1,PhaseType")] Phase phase)
        {
            if (id != phase.PhaseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhaseExists(phase.PhaseId))
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
            ViewData["PhaseType"] = new SelectList(_context.PhaseTypes, "PhaseType1", "PhaseType1", phase.PhaseType);
            return View(phase);
        }

        // GET: Phases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Phases == null)
            {
                return NotFound();
            }

            var phase = await _context.Phases
                .Include(p => p.PhaseTypeNavigation)
                .FirstOrDefaultAsync(m => m.PhaseId == id);
            if (phase == null)
            {
                return NotFound();
            }

            return View(phase);
        }

        // POST: Phases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Phases == null)
            {
                return Problem("Entity set 'AppDbContext.Phases'  is null.");
            }
            var phase = await _context.Phases.FindAsync(id);
            if (phase != null)
            {
                _context.Phases.Remove(phase);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhaseExists(int id)
        {
          return (_context.Phases?.Any(e => e.PhaseId == id)).GetValueOrDefault();
        }
    }
}
