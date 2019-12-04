using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment1_COMP2084_200400508.Data;
using Assignment1_COMP2084_200400508.Models;

namespace Assignment1_COMP2084_200400508.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TomesAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TomesAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TomesAPI
        [HttpGet]
        public IEnumerable<Tome> GetTome()
        {
            return _context.Tome;
        }

        // GET: api/TomesAPI/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tome = await _context.Tome.FindAsync(id);

            if (tome == null)
            {
                return NotFound();
            }

            return Ok(tome);
        }

        // PUT: api/TomesAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTome([FromRoute] int id, [FromBody] Tome tome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tome.TomeId)
            {
                return BadRequest();
            }

            _context.Entry(tome).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TomeExists(id))
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

        // POST: api/TomesAPI
        [HttpPost]
        public async Task<IActionResult> PostTome([FromBody] Tome tome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tome.Add(tome);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTome", new { id = tome.TomeId }, tome);
        }

        // DELETE: api/TomesAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTome([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tome = await _context.Tome.FindAsync(id);
            if (tome == null)
            {
                return NotFound();
            }

            _context.Tome.Remove(tome);
            await _context.SaveChangesAsync();

            return Ok(tome);
        }

        private bool TomeExists(int id)
        {
            return _context.Tome.Any(e => e.TomeId == id);
        }
    }
}