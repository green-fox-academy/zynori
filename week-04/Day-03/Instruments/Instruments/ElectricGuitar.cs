using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar() : base("Electric Guitar", 6) { }

        public ElectricGuitar(int numberOfStrings) : base("ElectricGuitar", numberOfStrings) { }
        
        
        public override void Play()
        {
            Console.WriteLine($"{name}, a {numberOfStrings}-stringed instrument that {Sound()}");
        }

        public override string Sound()
        {
            return "Twangs"; 
        }
    }
}
