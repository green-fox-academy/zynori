using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling([FromQuery]int input)
        {
            int result = input * 2;
            if (input != null)
            {
                return Json(new {received=input, result=result });
            }
            else
            {
                return Json(new { error = "Please provide an input!" });
            }
        }
    }
}