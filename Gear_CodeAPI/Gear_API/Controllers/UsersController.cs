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
    public class UsersController : ControllerBase
    {
// CONTEXT'S #####################################################################################################
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
// GET'S #########################################################################################################
        // GET: api/Users
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Users>>> Get()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUsers(int id)
        {
            var Users = await _context.Users.FindAsync(id);
            if (Users == null)
            {
                return NotFound();
            }
            return Users;
        }
        // GET: api/Users/email/user@user.com
        [HttpGet]
        [Route("email/{email}")]
        public async Task<ActionResult<Users>> GetByEmail(string email)
        {
            var users = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Use_email == email);
            if (users == null)
            {
                return NotFound();
            }
            return users;
        }
// POST'S ########################################################################################################
        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers(Users Users)
        {
            _context.Users.Add(Users);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetUsers", new { id = Users.Use_code }, Users);
        }
// PUT'S #########################################################################################################
        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Users Users)
        {
            if (id != Users.Use_code)
            {
                return BadRequest();
            }
            _context.Entry(Users).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
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
// DELETE'S ######################################################################################################
        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsers(int id)
        {
            var Users = await _context.Users.FindAsync(id);
            if (Users == null)
            {
                return NotFound();
            }
            _context.Users.Remove(Users);
            await _context.SaveChangesAsync();
            return NoContent();
        }
// EXIST'S #######################################################################################################
        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.Use_code == id);
        }
    }
}