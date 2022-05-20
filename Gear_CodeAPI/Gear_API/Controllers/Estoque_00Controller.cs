#nullable disable
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
    public class Estoque_00Controller : ControllerBase
    {
        private readonly DataContext _context;

        public Estoque_00Controller(DataContext context)
        {
            _context = context;
        }

        // GET: api/Estoque_00
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estoque_00>>> GetEstoque_00()
        {
            return await _context.Estoque_00.ToListAsync();
        }

        // GET: api/Estoque_00/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estoque_00>> GetEstoque_00(int id)
        {
            var estoque_00 = await _context.Estoque_00.FindAsync(id);

            if (estoque_00 == null)
            {
                return NotFound();
            }

            return estoque_00;
        }

        // PUT: api/Estoque_00/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstoque_00(int id, Estoque_00 estoque_00)
        {
            if (id != estoque_00.Etq_codigo)
            {
                return BadRequest();
            }

            _context.Entry(estoque_00).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Estoque_00Exists(id))
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

        // POST: api/Estoque_00
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Estoque_00>> PostEstoque_00(Estoque_00 estoque_00)
        {
            _context.Estoque_00.Add(estoque_00);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstoque_00", new { id = estoque_00.Etq_codigo }, estoque_00);
        }

        // DELETE: api/Estoque_00/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstoque_00(int id)
        {
            var estoque_00 = await _context.Estoque_00.FindAsync(id);
            if (estoque_00 == null)
            {
                return NotFound();
            }

            _context.Estoque_00.Remove(estoque_00);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Estoque_00Exists(int id)
        {
            return _context.Estoque_00.Any(e => e.Etq_codigo == id);
        }
    }
}
