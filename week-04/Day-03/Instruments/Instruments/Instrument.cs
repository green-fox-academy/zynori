﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class Instrument
    {
        private string name;

        protected string Name { get => name; set => name = value; }

        public abstract void Play();
        public abstract void Sound();
    }
}
