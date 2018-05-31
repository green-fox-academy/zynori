using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class InputString
    {
        public bool IsItAnagram(string first, string second)
        {
            char[] result = second.ToCharArray();
            Array.Reverse(result);
            second = new string(result);

            return (first.ToLower() == second.ToLower());
        }
    }
}
