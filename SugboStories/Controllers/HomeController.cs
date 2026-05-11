using Microsoft.AspNetCore.Mvc;
using SugboStories.Models;
using System.Diagnostics;

namespace SugboStories.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Stories() => View();
        public IActionResult Sites() => View();
        public IActionResult Archives() => View();
        public IActionResult Timeline() => View();
        public IActionResult About() => View();
        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}