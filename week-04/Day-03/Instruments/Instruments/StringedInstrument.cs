using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        protected StringedInstrument(string name, int numberOfStrings) : base(name)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public abstract string Sound();

    }
}
