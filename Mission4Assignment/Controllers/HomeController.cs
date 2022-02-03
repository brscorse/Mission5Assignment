using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieContext McContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            McContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieApplication()
        {
            ViewBag.Categories = McContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult MovieApplication(AppResponse ar)
        {
            if (ModelState.IsValid)
            {
                McContext.Add(ar);
                McContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = McContext.Categories.ToList();
                return View();
            }
            
        }

        public IActionResult FilmList()
        {
            var applications = McContext.responses
                .Include(x=> x.Category)
                .OrderBy(x=> x.Title)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = McContext.Categories.ToList();

            var application = McContext.responses.Single(x=> x.MovieId == movieid);

            return View("MovieApplication", application);
        }

        [HttpPost]
        public IActionResult Edit(AppResponse info)
        {
            McContext.Update(info);
            McContext.SaveChanges();

            return RedirectToAction("FilmList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var application = McContext.responses.Single(x => x.MovieId == movieid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(AppResponse ar)
        {
            McContext.responses.Remove(ar);
            McContext.SaveChanges();

            return RedirectToAction("FilmList");
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
