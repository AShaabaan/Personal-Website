using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;
using System.Diagnostics;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.Typed = " , Software Developer , Using .Net , Front-end Developer , Using Angular  , Open to job Opportunities ";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Title = "Privacy";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}