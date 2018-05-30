﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin(int NumberOfStrings)
        {
            this.NumberOfStrings = NumberOfStrings;
        }

        public Violin()
        {
            NumberOfStrings = 4;
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
