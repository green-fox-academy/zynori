using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    interface IChecker
    {
        String GetString();
        bool CheckString(string inputString);
    }
}
