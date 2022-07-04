using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPITandemMixer.Context;
using WebAPITandemMixer.Models;

namespace WebAPITandemMixer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhaseIngredientController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PhaseIngredientController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PhaseIngredient
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhaseIngredient>>> GetPhaseIngredients()
        {
          if (_context.PhaseIngredients == null)
          {
              return NotFound();
          }
            return await _context.PhaseIngredients.ToListAsync();
        }

        // GET: api/PhaseIngredient/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhaseIngredient>> GetPhaseIngredient(int id)
        {
          if (_context.PhaseIngredients == null)
          {
              return NotFound();
          }
            var phaseIngredient = await _context.PhaseIngredients.FindAsync(id);

            if (phaseIngredient == null)
            {
                return NotFound();
            }

            return phaseIngredient;
        }

        // PUT: api/PhaseIngredient/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhaseIngredient(int id, PhaseIngredient phaseIngredient)
        {
            if (id != phaseIngredient.PhaseId)
            {
                return BadRequest();
            }

            _context.Entry(phaseIngredient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhaseIngredientExists(id))
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

        // POST: api/PhaseIngredient
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PhaseIngredient>> PostPhaseIngredient(PhaseIngredient phaseIngredient)
        {
          if (_context.PhaseIngredients == null)
          {
              return Problem("Entity set 'AppDbContext.PhaseIngredients'  is null.");
          }
            _context.PhaseIngredients.Add(phaseIngredient);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PhaseIngredientExists(phaseIngredient.PhaseId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPhaseIngredient", new { id = phaseIngredient.PhaseId }, phaseIngredient);
        }

        // DELETE: api/PhaseIngredient/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhaseIngredient(int id)
        {
            if (_context.PhaseIngredients == null)
            {
                return NotFound();
            }
            var phaseIngredient = await _context.PhaseIngredients.FindAsync(id);
            if (phaseIngredient == null)
            {
                return NotFound();
            }

            _context.PhaseIngredients.Remove(phaseIngredient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PhaseIngredientExists(int id)
        {
            return (_context.PhaseIngredients?.Any(e => e.PhaseId == id)).GetValueOrDefault();
        }
    }
}
