using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SquadFree_Back.DAL;
using SquadFree_Back.Models;
using SquadFree_Back.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SquadFree_Back.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _db { get;  }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            HomeVM testimonials = new HomeVM
            {
                Testimonials = _db.Testimonials.ToList()
            };
            return View(testimonials);
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
    }
}
