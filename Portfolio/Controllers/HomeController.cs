using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;           // assuming you have ErrorViewModel here
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        // You can keep this simple if the home page is purely static
        public IActionResult Index()
        {
            // Optional: you can pass data to the view if needed later
            // ViewData["Title"] = "Ashish | .NET Developer & Full-Stack Enthusiast";
            // ViewBag.ActivePage = "Home";

            return View();
        }

        public IActionResult About()
        {
            // ViewData["Title"] = "About Me - Ashish";
            return View();
        }

        public IActionResult Skills()
        {
            // ViewData["Title"] = "Skills & Technologies - Ashish";
            return View();
        }

        public IActionResult Projects()
        {
            // ViewData["Title"] = "Projects - Ashish";
            // You can later load real project data here (from JSON, DB, etc.)
            return View();
        }

        public IActionResult Contact()
        {
            // ViewData["Title"] = "Contact - Ashish";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}