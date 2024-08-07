using System.ComponentModel.DataAnnotations;
using Lab02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
        ViewBag.Fifteen = 0.0;
        ViewBag.Twenty = 0.0;
        ViewBag.TwentyFive = 0.0;
        return View();
        }


        [HttpPost]
        public IActionResult Index(Calculator calc) 
        { 
        ViewBag.Fifteen = calc.MealCost * .15;
        ViewBag.Twenty = calc.MealCost * .20;
        ViewBag.TwentyFive = calc.MealCost * .25;
        return View(calc);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
