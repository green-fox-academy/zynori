using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class StringedInstrument : Instrument
    {
        private int numberOfStrings;

        public int NumberOfStrings { get => numberOfStrings; set => numberOfStrings = value; }

        public override void Play()
        {
            
        }

        public override void Sound()
        {
            
        }
    }
}
