using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4Assignment.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieApplication()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieApplication(AppResponse ar)
        {
            if (ModelState.IsValid)
            {
                _blahContext.Add(ar);
                _blahContext.SaveChanges();
                return View("Confirmation", ar);
            }
            return View();
        }

        public IActionResult MyPodcasts()
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
