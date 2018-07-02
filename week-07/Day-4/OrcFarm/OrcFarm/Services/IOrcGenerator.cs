using OrcFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcFarm.Services
{
    public interface IOrcGenerator
    {
        string GetName();
        void SetName(string inputName);

        string GetFood();
        void AddFood(string inputFood);

        List<string> GetTricks(string Name);
    }
}
