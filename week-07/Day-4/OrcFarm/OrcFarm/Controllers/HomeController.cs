using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrcFarm.Models;
using OrcFarm.Services;

namespace OrcFarm.Controllers
{
    public class HomeController : Controller
    {
        private IOrcGenerator orcGenerator;

        public HomeController(IOrcGenerator orcGenerator)
        {
            this.orcGenerator = orcGenerator;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return Redirect("login");
        }

        [HttpPost("login")]
        public IActionResult GetName(string orcName)
        {
            orcGenerator.SetName(orcName);
            return RedirectToAction("info", orcGenerator);
        }

        [HttpGet("info")]
        public IActionResult Info()
        {
            return View(orcGenerator);
        }

        [HttpPost("info")]
        public IActionResult Info(string orcFood, string Name)
        {
            orcGenerator.AddFood(orcFood);
            orcGenerator.GetTricks(Name);
            return RedirectToAction("info", orcGenerator);
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
