using OrcFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcFarm.Services
{
    public class OrcService : IOrcGenerator
    {
        Orc orcs = new Orc() { Tricks = new List<string>() };

        List<string> tricks = new List<string>() { "dance", "be polite", "build things", "kill... negativity" };

        public void AddFood(string inputFood)
        {
            orcs.Food = inputFood;
        }

        public string GetFood()
        {
            return orcs.Food;
        }

        public string GetName()
        {
            return orcs.Name;
        }

        public void SetName(string inputName)
        {
            orcs.Name = inputName;
        }

        public List<string> GetTricks(string Name)
        {
            return tricks;
        }
    }
}
