using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int NumberOfStrings)
        {
            this.NumberOfStrings = NumberOfStrings;
        }

        public ElectricGuitar()
        {
            NumberOfStrings = 6;
        }
        
        public override string Sound()
        {
            return "Twang";
        }
    }
}
