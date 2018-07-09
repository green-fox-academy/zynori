using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
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
            if (name != null && title != null)
            {
                return Json(new
                {
                    welcome_message = $"Oh, hi there {name}, my dear {title}!"
                });
            }
            else
            {
                return Json(new
                {
                    error = "Please provide both the name and the title!"
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
            return Json(new { error = "Please provide a working function!" });
        }

        [HttpPost("/arrays")]
        public IActionResult Arrays([FromBody] Arrays array)
        {
            int result;
            List<int> doubledResult;

            if (array.what.Equals("sum"))
            {
                result = 1;
                foreach (int item in array.numbers)
                {
                    result += item;
                }

                return Json(new { result });
            }
            else if (array.what.Equals("multiply"))
            {
                result = 1;
                foreach (int item in array.numbers)
                {
                    result *= item;
                }

                return Json(new { result });
            }
            else if (array.what.Equals("double"))
            {
                doubledResult = new List<int>();
                foreach (int item in array.numbers)
                {
                    doubledResult.Add(item * 2);
                }

                return Json(new { doubledResult });
            }
            return Json(new { error = "Please provide what to do with the numbers!" });
        }
    }
}