using GreetSomeone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Services
{
    public interface IGreetSomeone
    {
        Name GetName();
        void SetName(string inputName);
    }
}
