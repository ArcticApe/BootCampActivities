using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exercise9.Models;

namespace Exercise9.Controllers
{
    public class WatchCatalogsController : Controller
    {
        private readonly WatchCatalogContext _context;

        public WatchCatalogsController(WatchCatalogContext context)
        {
            _context = context;
        }

        // GET: WatchCatalogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.WatchCatalog.ToListAsync());
        }

        // GET: WatchCatalogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var watchCatalog = await _context.WatchCatalog
                .FirstOrDefaultAsync(m => m.WatchId == id);
            if (watchCatalog == null)
            {
                return NotFound();
            }

            return View(watchCatalog);
        }

        // GET: WatchCatalogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WatchCatalogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WatchId,ShortDesc,FullDesc,WatchName,ProductNumber,Price,WatchHeight,WatchWeight,WatchDiameter,WatchThickness,Caliber,Movement,Jewel,Chronograph,CaseMaterial,StrapMaterial")] WatchCatalog watchCatalog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(watchCatalog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(watchCatalog);
        }

        // GET: WatchCatalogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var watchCatalog = await _context.WatchCatalog.FindAsync(id);
            if (watchCatalog == null)
            {
                return NotFound();
            }
            return View(watchCatalog);
        }

        // POST: WatchCatalogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WatchId,ShortDesc,FullDesc,WatchName,ProductNumber,Price,WatchHeight,WatchWeight,WatchDiameter,WatchThickness,Caliber,Movement,Jewel,Chronograph,CaseMaterial,StrapMaterial")] WatchCatalog watchCatalog)
        {
            if (id != watchCatalog.WatchId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(watchCatalog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WatchCatalogExists(watchCatalog.WatchId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(watchCatalog);
        }

        // GET: WatchCatalogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var watchCatalog = await _context.WatchCatalog
                .FirstOrDefaultAsync(m => m.WatchId == id);
            if (watchCatalog == null)
            {
                return NotFound();
            }

            return View(watchCatalog);
        }

        // POST: WatchCatalogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var watchCatalog = await _context.WatchCatalog.FindAsync(id);
            _context.WatchCatalog.Remove(watchCatalog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WatchCatalogExists(int id)
        {
            return _context.WatchCatalog.Any(e => e.WatchId == id);
        }
    }
}
