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
        public IActionResult Doubling([FromQuery]int? input)
        {
            if (input != null)
            {
                return Json(new
                {
                    received =input, result=input*2
                });
            }
            else
            {
                return Json(new
                {
                    error = "Please provide an input!"
                });
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter([FromQuery] string name, [FromQuery] string title)
        {
            if (name == null)
            {
                return Json(new
                {
                    error = "Please provide a name!"
                });
            }
            else if (title == null)
            {
                return Json(new
                {
                    error = "Please provide a title!"
                });
            }
            else
            {
                return Json(new
                {
                    welcome_message = $"Oh, hi there {name}, my dear {title}!"
                });
            }
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            if (appendable is null)
            {
                return NotFound();
            }
            else
            {
                return Json(new
                {
                    appended = $"{appendable}a"
                });
            }
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody]Number number)
        {
            int result;

            if (number.Until is null)
            {
                return Json(new
                {
                    error = "Please provide a number!"
                });
            }
            else
            {
                if (what == "sum")
                {
                    result = 0;

                    for (int i = 1; i < number.Until + 1; i++)
                    {
                        result += i;
                    }
                    return Json(new { result });
                }
                if (what == "factor")
                {
                    result = 1;

                    for (int i = 1; i < number.Until + 1; i++)
                    {
                        result *= i;
                    }
                    return Json(new { result });
                }
            }
            return Json(new { error = "Please provide a working function!" });
        }
    }
}