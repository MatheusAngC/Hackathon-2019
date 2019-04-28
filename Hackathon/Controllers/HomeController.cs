using Hackathon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hackathon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.VagasNaoOcupadas = 50;
            ViewBag.VagasOcupadas = 75;

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