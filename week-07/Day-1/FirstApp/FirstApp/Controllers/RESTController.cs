using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting greets = new Greeting(name);
            
            return new JsonResult(greets);
        }
    }
}