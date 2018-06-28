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
            return Redirect("/login");
        }

        [HttpPost("/login")]
        public IActionResult GetName(string orcName)
        {
            orcGenerator.SetName(orcName);
            return RedirectToAction("info");
        }

        [HttpGet("info")]
        public IActionResult Info()
        {
            return View(orcGenerator.GetName());
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
