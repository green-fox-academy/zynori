using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin() : base("Violin", 4) { }

        public Violin(int numberOfStrings) : base("Violin", numberOfStrings) { }

        public override void Play()
        {
            Console.WriteLine($"{name}, a {numberOfStrings}-stringed instrument that {Sound()}");
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
