using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar() : base("Bass Guitar", 4) { }

        public BassGuitar(int numberOfStrings) : base("Bass Guitar", numberOfStrings) { }

        public override void Play()
        {
            Console.WriteLine($"{name}, a {numberOfStrings}-stringed instrument that {Sound()}");
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
