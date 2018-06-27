using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeone.Models;
using GreetSomeone.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeone.Controllers
{
    public class GreetingController : Controller
    {
        private IGreetSomeone greetSomeoneService;

        public GreetingController(IGreetSomeone greetSomeoneService)
        {
            this.greetSomeoneService = greetSomeoneService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult GetName(string MyName)
        {
            greetSomeoneService.SetName(MyName);
            return RedirectToAction("greet");
        }

        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return View(greetSomeoneService.GetName());
        }
    }
}