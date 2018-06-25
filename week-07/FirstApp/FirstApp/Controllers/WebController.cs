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

        [Route("helloka")]
        public IActionResult Helloka()
        {
            MultipleColoredGreeting coloredGreeting = new MultipleColoredGreeting()
            {
                hellos;
            }
        }
    }
}