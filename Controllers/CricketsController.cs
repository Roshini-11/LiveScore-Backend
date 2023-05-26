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
    public class CricketsController : ControllerBase
    {
        private readonly LiveScoreContext _context;

        public CricketsController(LiveScoreContext context)
        {
            _context = context;
        }

        // GET: api/Crickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cricket>>> GetCrickets()
        {
          if (_context.Crickets == null)
          {
              return NotFound();
          }
            return await _context.Crickets.ToListAsync();
        }

        // GET: api/Crickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cricket>> GetCricket(int id)
        {
          if (_context.Crickets == null)
          {
              return NotFound();
          }
            var cricket = await _context.Crickets.FindAsync(id);

            if (cricket == null)
            {
                return NotFound();
            }

            return cricket;
        }

        // PUT: api/Crickets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCricket(int id, Cricket cricket)
        {
            if (id != cricket.Id)
            {
                return BadRequest();
            }

            _context.Entry(cricket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CricketExists(id))
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

        // POST: api/Crickets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cricket>> PostCricket(Cricket cricket)
        {
          if (_context.Crickets == null)
          {
              return Problem("Entity set 'LiveScoreContext.Crickets'  is null.");
          }
            _context.Crickets.Add(cricket);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CricketExists(cricket.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCricket", new { id = cricket.Id }, cricket);
        }

        // DELETE: api/Crickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCricket(int id)
        {
            if (_context.Crickets == null)
            {
                return NotFound();
            }
            var cricket = await _context.Crickets.FindAsync(id);
            if (cricket == null)
            {
                return NotFound();
            }

            _context.Crickets.Remove(cricket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CricketExists(int id)
        {
            return (_context.Crickets?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
