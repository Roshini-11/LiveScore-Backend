using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LiveScore.Data;
using LiveScore.Models;

namespace LiveScore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KabaddisController : ControllerBase
    {
        private readonly LiveScoreContext _context;

        public KabaddisController(LiveScoreContext context)
        {
            _context = context;
        }

        // GET: api/Kabaddis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kabaddi>>> GetKabaddis()
        {
          if (_context.Kabaddis == null)
          {
              return NotFound();
          }
            return await _context.Kabaddis.ToListAsync();
        }

        // GET: api/Kabaddis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kabaddi>> GetKabaddi(int id)
        {
          if (_context.Kabaddis == null)
          {
              return NotFound();
          }
            var kabaddi = await _context.Kabaddis.FindAsync(id);

            if (kabaddi == null)
            {
                return NotFound();
            }

            return kabaddi;
        }

        // PUT: api/Kabaddis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKabaddi(int id, Kabaddi kabaddi)
        {
            if (id != kabaddi.Id)
            {
                return BadRequest();
            }

            _context.Entry(kabaddi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KabaddiExists(id))
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

        // POST: api/Kabaddis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Kabaddi>> PostKabaddi(Kabaddi kabaddi)
        {
          if (_context.Kabaddis == null)
          {
              return Problem("Entity set 'LiveScoreContext.Kabaddis'  is null.");
          }
            _context.Kabaddis.Add(kabaddi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (KabaddiExists(kabaddi.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetKabaddi", new { id = kabaddi.Id }, kabaddi);
        }

        // DELETE: api/Kabaddis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKabaddi(int id)
        {
            if (_context.Kabaddis == null)
            {
                return NotFound();
            }
            var kabaddi = await _context.Kabaddis.FindAsync(id);
            if (kabaddi == null)
            {
                return NotFound();
            }

            _context.Kabaddis.Remove(kabaddi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KabaddiExists(int id)
        {
            return (_context.Kabaddis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
