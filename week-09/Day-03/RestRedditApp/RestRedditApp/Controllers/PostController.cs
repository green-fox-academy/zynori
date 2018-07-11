using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestRedditApp.Services;

namespace RestRedditApp.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class PostController : Controller
    {
        private IService database;

        public PostController(IService database)
        {
            this.database = database;
        }

        public IActionResult Index()
        {
            return Json(new { });
        }
    }
}