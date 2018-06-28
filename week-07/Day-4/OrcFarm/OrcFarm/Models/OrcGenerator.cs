using OrcFarm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcFarm.Models
{
    public class OrcGenerator : IOrcGenerator
    {
        private Name storedName;

        public OrcGenerator()
        {
            storedName = new Name() { orcName = string.Empty };
        }

        public Name GetName()
        {
            return storedName;
        }

        public void SetName(string inputName)
        {
            storedName.orcName = inputName;
        }
    }
}
