using Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherService _weatherService;

        public HomeController(ILogger<HomeController> logger, IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(HomeViewModel vm)
        {
            if (ModelState.IsValid)
            {
                //burada servis kullan, 17 yazmak yerine
                vm.Temperature = _weatherService.Temperature(vm.Place);
            }
            return View(vm);
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