using Microsoft.AspNetCore.Mvc;

namespace MyAppNamespace.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/About
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        // GET: /Home/Contact
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }
    }
}
