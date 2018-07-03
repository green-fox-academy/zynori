using OrcFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcFarm.Services
{
    public interface IOrcGenerator
    {
        Orc GetOrc();
        void SetName(string inputName);

        void SetFood(string inputFood);

        List<string> GetAvailableTricks();
        void SetTrick(string trick);
    }
}
