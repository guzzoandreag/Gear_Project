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
    public class Produto_00Controller : ControllerBase
    {
        private readonly DataContext _context;

        public Produto_00Controller(DataContext context)
        {
            _context = context;
        }

        // GET: api/Produto_00
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto_00>>> GetProdutos_00()
        {
            return await _context.Produtos_00.ToListAsync();
        }

        // GET: api/Produto_00/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto_00>> GetProduto_00(int id)
        {
            var produto_00 = await _context.Produtos_00.FindAsync(id);

            if (produto_00 == null)
            {
                return NotFound();
            }

            return produto_00;
        }

        // PUT: api/Produto_00/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto_00(int id, [FromBody] Produto_00 produto_00)
        {
            if (id != produto_00.Pro_codigo)
            {
                return BadRequest();
            }

            _context.Entry(produto_00).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Produto_00Exists(id))
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

        // POST: api/Produto_00
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Produto_00>> PostProduto_00(Produto_00 produto_00)
        {
            _context.Produtos_00.Add(produto_00);
            await _context.SaveChangesAsync();

            var result = CreatedAtAction("GetProduto_00", new { id = produto_00.Pro_codigo }, produto_00);
            return result;
        }


        // DELETE: api/Produto_00/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto_00(int id)
        {
            var produto_00 = await _context.Produtos_00.FindAsync(id);
            if (produto_00 == null)
            {
                return NotFound();
            }

            _context.Produtos_00.Remove(produto_00);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Produto_00Exists(int id)
        {
            return _context.Produtos_00.Any(e => e.Pro_codigo == id);
        }
    }
}
