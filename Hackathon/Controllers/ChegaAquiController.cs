using Hackathon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Hackathon.Controllers
{
    public class ChegaAquiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.VagasNaoOcupadas = 50;
            ViewBag.VagasOcupadas = 75;

            return View();
        }

        public IActionResult Login()
        {
            ViewBag.VagasNaoOcupadas = 50;
            ViewBag.VagasOcupadas = 75;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ClienteIndex()
        {
            var lista = new List<Vagas>();
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Quinze de novembro", "200m", 5));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Dr. Amadeu da Luz", "300m", 4));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Pres. John Kenedy", "250m", 5));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Ingo Hering", "350m", 5));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Pres. Getúlio Vargas", "300m", 4));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Ângelo Dias", "250m", 5));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Eng. Rodolfo Ferraz", "450m", 5));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. São Paulo", "500m", 5));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Mal. Floriano Peixoto", "500m", 4));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Alameda Rio Branco", "400m", 3));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. R. Dr. Luiz de Freitas Melro", "500m", 4));
            lista.Add(new Vagas(Guid.NewGuid(), null, "Centro, R. Antônio da Veiga", "1,3km", 5));
            return View(lista);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}