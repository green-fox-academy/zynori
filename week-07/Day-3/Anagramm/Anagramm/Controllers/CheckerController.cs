using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagramm.Services;
using Anagramm.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anagramm.Controllers
{
    public class CheckerController : Controller
    {
        private IChecker anagramCheckerService;
        
        public CheckerController(IChecker anagramCheckerService)
        {
            this.anagramCheckerService = anagramCheckerService;
        }
        
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult GetString(string MyString)
        {
            anagramCheckerService.CheckString(MyString);
            return RedirectToAction("isanagram");
        }

        [HttpGet("isanagram")]
        public IActionResult Checker()
        {
            return View(anagramCheckerService.CheckString());
        }
    }
}