using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting()
        {
            Greeting greeting = new Greeting()
            {
                Content = "yolo"
            };

            return View(greeting);
        }

        [Route("helloka/{name}")]
        public IActionResult MultipleColoredGreeting(string name)
        {
            MultipleColoredGreeting coloredGreeting = new MultipleColoredGreeting()
            {
                Name = name
            };

            return View(coloredGreeting);
        }
    }
}