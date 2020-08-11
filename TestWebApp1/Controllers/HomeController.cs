using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HomePageApp.Models;
using System.Collections;

namespace HomePageApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LinksDbContext _context;
        private readonly HttpGetClass _getClass;

        public HomeController(ILogger<HomeController> logger, LinksDbContext context, HttpGetClass getClass)
        {
            _logger = logger;
            _context = context;
            _getClass = getClass;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_getClass.HttpGetMethod());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Post(List<Link> linkPost)
        {
            _context.Links.Update(linkPost[0]);
            _context.SaveChanges();
            return NoContent();
        }
    }
}