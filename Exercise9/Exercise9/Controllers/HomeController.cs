using Exercise9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise9.Controllers
{
    public class HomeController : Controller
    {
        private readonly WatchCatalogContext _context;

        public HomeController(WatchCatalogContext context)
        {
            _context = context;
        }

        // GET: WatchCatalogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.WatchCatalog.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
