using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    public class AnagramCheckerService : IChecker
    {
        private String storedString;
        
        public string GetString()
        {
            return storedString;
        }

        public bool CheckString(string inputString)
        {
            return inputString.OrderBy(c => c).SequenceEqual(inputString.OrderBy(c => c));
        }
    }
}
