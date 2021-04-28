using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortfolioDiseño.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PortfolioDiseño.Data;
using Microsoft.EntityFrameworkCore;

namespace PortfolioDiseño.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortfolioDiseñoContext _context;

        public HomeController(PortfolioDiseñoContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Galery()
        {
            return View(await _context.Works.Where(x => x.Active).ToListAsync());
        }

        public IActionResult Contact()
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
