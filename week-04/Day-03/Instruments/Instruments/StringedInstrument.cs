using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class StringedInstrument : Instrument
    {
        private int numberOfStrings;

        public int NumberOfStrings { get => numberOfStrings; set => numberOfStrings = value; }

        public abstract string Sound();

        public override void Play()
        {
            Sound();
        }
    }
}
