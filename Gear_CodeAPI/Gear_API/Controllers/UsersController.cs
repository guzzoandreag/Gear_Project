﻿#nullable disable
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
        // GET: api/Users
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Users>>> Get([FromServices] DataContext context)
        {
            var users = await context.Users.ToListAsync();
            return users;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUsers([FromServices] DataContext context, int id)
        {
            var Users = await context.Users.FindAsync(id);

            if (Users == null)
            {
                return NotFound();
            }

            return Users;
        }

        // GET: api/Users/email/user@user.com
        [HttpGet]
        [Route("email/{email}")]
        public async Task<ActionResult<Users>> GetByEmail([FromServices] DataContext context, string email)
        {
            var users = await context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Use_email == email);
            if (users == null)
            {
                return NotFound();
            }
            return users;
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers([FromServices] DataContext context, Users Users)
        {
            context.Users.Add(Users);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = Users.Use_code }, Users);
        }

        //// PUT: api/Users/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUsers(int id, Users Users)
        //{
        //    if (id != Users.Use_code)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(Users).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UsersExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// DELETE: api/Users/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUsers(int id)
        //{
        //    var Users = await _context.Users.FindAsync(id);
        //    if (Users == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Users.Remove(Users);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool UsersExists(int id)
        //{
        //    return _context.Users.Any(e => e.Use_code == id);
        //}
    }
}