using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simba.Models
{
    public class BankAccount
    {
        public bool isKing;

        public string Name { get; set; }
        public int Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; }

        public BankAccount()
        {
            Currency = "Zebra";
            isKing = false;
        }
    }
}
