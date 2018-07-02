using OrcFarm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcFarm.Models
{
    public class Orc
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public List<string> Tricks { get; set; }
    }
}
