using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simba.Models;

namespace Simba.Controllers
{
    [Route("account")]
    public class BankAccountController : Controller
    {
        [Route("simba")]
        public IActionResult Simba()
        {
            BankAccount account = new BankAccount() { Name = "Simba", Balance = 2000, AnimalType = "Lion" };
            return View(account);
        }
        
        [Route("lionking")]
        public IActionResult LionKing()
        {
            List<BankAccount> accounts = new List<BankAccount>(){
                new BankAccount { Name = "Mufasa", Balance = 650_000_000, AnimalType = "Lion", isKing = true },
                new BankAccount { Name = "Nala", Balance = 66, AnimalType = "Lion" },
                new BankAccount { Name = "Timon", Balance = 0, AnimalType = "Meerkat" },
                new BankAccount { Name = "Zazu", Balance = 1, AnimalType = "Hornbill" }
            };

            return View(accounts);
        }
    }
}