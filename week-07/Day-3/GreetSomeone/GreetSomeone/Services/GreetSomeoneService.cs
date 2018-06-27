using GreetSomeone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Services
{
    public class GreetSomeoneService : IGreetSomeone
    {
        private Name storedName;

        public GreetSomeoneService()
        {
            storedName = new Name() { MyName = string.Empty };
        }

        public Name GetName()
        {
            return storedName;
        }

        public void SetName(string inputName)
        {
            storedName.MyName = inputName;
        }
    }
}
