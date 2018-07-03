using OrcFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcFarm.Services
{
    public class OrcService : IOrcGenerator
    {
        Orc orc = new Orc() { Tricks = new List<string>() };

        List<string> tricks = new List<string>() { "dance", "be polite", "build things", "kill... negativity" };

        public Orc GetOrc()
        {
            return orc;
        }

        public string GetTricksFormated()
        {
            return String.Join(", ", orc.Tricks.ToArray());
        }

        public void SetName(string inputName)
        {
            orc.Name = inputName;
        }

        public void SetFood(string inputFood)
        {
            orc.Food = inputFood;
        }
        
        public void SetTrick(string trick)
        {
            if (!orc.Tricks.Contains(trick))
            {
                orc.Tricks.Add(trick);
            }
        }

        public List<string> GetAvailableTricks()
        {
            return tricks;
        }
    }
}
