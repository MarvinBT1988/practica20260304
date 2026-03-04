using Microsoft.AspNetCore.Mvc;
using Practica04032026.AppWeb.Models;
using System.Diagnostics;

namespace Practica04032026.AppWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // soy marvin
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
