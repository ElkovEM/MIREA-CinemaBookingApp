using CinemaBookingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

/*
 * Файл контроллера, отвечающего за переходы между страницами
 */
namespace CinemaBookingApp.Controllers
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
            return View(); // Показывает клиенту страницу Index.cshtml
        }

        public IActionResult Privacy()
        {
            return View();  // Показывает клиенту страницу Privacy.cshtml
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}