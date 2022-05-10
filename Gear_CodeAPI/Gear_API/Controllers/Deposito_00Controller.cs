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
    public class Deposito_00Controller : ControllerBase
    {
        private readonly DataContext _context;

        public Deposito_00Controller(DataContext context)
        {
            _context = context;
        }

        // GET: api/Deposito_00
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deposito_00>>> GetDeposito_00()
        {
            return await _context.Deposito_00.ToListAsync();
        }

        // GET: api/Deposito_00/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Deposito_00>> GetDeposito_00(int id)
        {
            var deposito_00 = await _context.Deposito_00.FindAsync(id);

            if (deposito_00 == null)
            {
                return NotFound();
            }

            return deposito_00;
        }

        // PUT: api/Deposito_00/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeposito_00(int id, Deposito_00 deposito_00)
        {
            if (id != deposito_00.Dep_code)
            {
                return BadRequest();
            }

            _context.Entry(deposito_00).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Deposito_00Exists(id))
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

        // POST: api/Deposito_00
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Deposito_00>> PostDeposito_00(Deposito_00 deposito_00)
        {
            _context.Deposito_00.Add(deposito_00);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeposito_00", new { id = deposito_00.Dep_code }, deposito_00);
        }

        // DELETE: api/Deposito_00/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeposito_00(int id)
        {
            var deposito_00 = await _context.Deposito_00.FindAsync(id);
            if (deposito_00 == null)
            {
                return NotFound();
            }

            _context.Deposito_00.Remove(deposito_00);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Deposito_00Exists(int id)
        {
            return _context.Deposito_00.Any(e => e.Dep_code == id);
        }
    }
}
