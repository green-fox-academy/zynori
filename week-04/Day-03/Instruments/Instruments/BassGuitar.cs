using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar(int NumberOfStrings)
        {
            this.NumberOfStrings = NumberOfStrings;
        }

        public BassGuitar()
        {
            NumberOfStrings = 4;
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
