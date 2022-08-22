using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exercise10API.Models;

namespace Exercise10API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchCatalogController : ControllerBase
    {
        private readonly WatchCatalogContext _context;

        public WatchCatalogController(WatchCatalogContext context)
        {
            _context = context;
        }

        // GET: api/WatchCatalog
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WatchCatalogTable>>> GetWatchCatalogTable()
        {
            return await _context.WatchCatalogTable.ToListAsync();
        }

        // GET: api/WatchCatalog/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WatchCatalogTable>> GetWatchCatalogTable(int id)
        {
            var watchCatalogTable = await _context.WatchCatalogTable.FindAsync(id);

            if (watchCatalogTable == null)
            {
                return NotFound();
            }

            return watchCatalogTable;
        }

        // PUT: api/WatchCatalog/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWatchCatalogTable(int id, WatchCatalogTable watchCatalogTable)
        {
            if (id != watchCatalogTable.WatchId)
            {
                return BadRequest();
            }

            _context.Entry(watchCatalogTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WatchCatalogTableExists(id))
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

        // POST: api/WatchCatalog
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<WatchCatalogTable>> PostWatchCatalogTable(WatchCatalogTable watchCatalogTable)
        {
            _context.WatchCatalogTable.Add(watchCatalogTable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWatchCatalogTable", new { id = watchCatalogTable.WatchId }, watchCatalogTable);
        }

        // DELETE: api/WatchCatalog/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WatchCatalogTable>> DeleteWatchCatalogTable(int id)
        {
            var watchCatalogTable = await _context.WatchCatalogTable.FindAsync(id);
            if (watchCatalogTable == null)
            {
                return NotFound();
            }

            _context.WatchCatalogTable.Remove(watchCatalogTable);
            await _context.SaveChangesAsync();

            return watchCatalogTable;
        }

        private bool WatchCatalogTableExists(int id)
        {
            return _context.WatchCatalogTable.Any(e => e.WatchId == id);
        }
    }
}
