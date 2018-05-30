﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class Instrument
    {
        protected string name;

        public Instrument(string name)
        {
            this.name = name;
        }

        public abstract void Play();
    }
}
