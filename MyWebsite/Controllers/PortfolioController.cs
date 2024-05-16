using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult SocialMedia()
        {
            return View();
        }

        public IActionResult Cv()
        {
            return View();
        }
    }
}
