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
    public class CompoundController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CompoundController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Compound
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compound>>> GetCompounds()
        {
          if (_context.Compounds == null)
          {
              return NotFound();
          }
            return await _context.Compounds.ToListAsync();
        }

        // GET: api/Compound/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Compound>> GetCompound(string id)
        {
          if (_context.Compounds == null)
          {
              return NotFound();
          }
            var compound = await _context.Compounds.FindAsync(id);

            if (compound == null)
            {
                return NotFound();
            }

            return compound;
        }

        // PUT: api/Compound/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompound(string id, Compound compound)
        {
            if (id != compound.CompoundName)
            {
                return BadRequest();
            }

            _context.Entry(compound).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompoundExists(id))
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

        // POST: api/Compound
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Compound>> PostCompound(Compound compound)
        {
          if (_context.Compounds == null)
          {
              return Problem("Entity set 'AppDbContext.Compounds'  is null.");
          }
            _context.Compounds.Add(compound);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CompoundExists(compound.CompoundName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCompound", new { id = compound.CompoundName }, compound);
        }

        // DELETE: api/Compound/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompound(string id)
        {
            if (_context.Compounds == null)
            {
                return NotFound();
            }
            var compound = await _context.Compounds.FindAsync(id);
            if (compound == null)
            {
                return NotFound();
            }

            _context.Compounds.Remove(compound);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompoundExists(string id)
        {
            return (_context.Compounds?.Any(e => e.CompoundName == id)).GetValueOrDefault();
        }
    }
}
