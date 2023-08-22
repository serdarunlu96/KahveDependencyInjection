using Interfaces;
using KahveDependencyInjection.Models;
using KahveDependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KahveDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly Latte _latte1;
        private readonly Latte _latte2;
        private readonly Mocca _mocca1;
        private readonly Mocca _mocca2;

        public HomeController(ILogger<HomeController> logger, Latte latte1, Latte latte2, Mocca mocca1, Mocca mocca2)
        {
            _logger = logger;
            _latte1 = latte1;
            _latte2 = latte2;
            _mocca1 = mocca1;
            _mocca2 = mocca2;
        }

        public IActionResult Index()
        {
           
            ViewBag.Latte1 = _latte1.GetNumber();
            ViewBag.Latte2 = _latte2.GetNumber();

            ViewBag.Mocca1 = _mocca1.GetNumber();
            ViewBag.Mocca2 = _mocca2.GetNumber();

            return View();
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