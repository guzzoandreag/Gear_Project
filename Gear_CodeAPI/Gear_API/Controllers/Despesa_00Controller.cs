using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gear_API.Data;
using Gear_API.Models;

namespace Gear_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Despesa_00Controller : ControllerBase
    {
        private readonly DataContext _context;

        public Despesa_00Controller(DataContext context)
        {
            _context = context;
        }

        // GET: api/Despesa_00
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Despesa_00>>> GetDespesa_00()
        {
          if (_context.Despesa_00 == null)
          {
              return NotFound();
          }
            return await _context.Despesa_00.ToListAsync();
        }

        // GET: api/Despesa_00/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Despesa_00>> GetDespesa_00(int id)
        {
          if (_context.Despesa_00 == null)
          {
              return NotFound();
          }
            var despesa_00 = await _context.Despesa_00.FindAsync(id);

            if (despesa_00 == null)
            {
                return NotFound();
            }

            return despesa_00;
        }

        // PUT: api/Despesa_00/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDespesa_00(int id, Despesa_00 despesa_00)
        {
            if (id != despesa_00.Des_codigo)
            {
                return BadRequest();
            }

            _context.Entry(despesa_00).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Despesa_00Exists(id))
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

        // POST: api/Despesa_00
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Despesa_00>> PostDespesa_00(Despesa_00 despesa_00)
        {
          if (_context.Despesa_00 == null)
          {
              return Problem("Entity set 'DataContext.Despesa_00'  is null.");
          }
            _context.Despesa_00.Add(despesa_00);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDespesa_00", new { id = despesa_00.Des_codigo }, despesa_00);
        }

        // DELETE: api/Despesa_00/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDespesa_00(int id)
        {
            if (_context.Despesa_00 == null)
            {
                return NotFound();
            }
            var despesa_00 = await _context.Despesa_00.FindAsync(id);
            if (despesa_00 == null)
            {
                return NotFound();
            }

            _context.Despesa_00.Remove(despesa_00);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Despesa_00Exists(int id)
        {
            return (_context.Despesa_00?.Any(e => e.Des_codigo == id)).GetValueOrDefault();
        }
    }
}
