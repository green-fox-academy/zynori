using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirate
    {
        protected List<string> pirates;
        protected int toxicateLevel;

        public Pirate(List<string> pirates, int toxicateLevel)
        {
            this.pirates = pirates;
            this.toxicateLevel = toxicateLevel;
        }

        public void DrinkSomeRum()
        {
            toxicateLevel++;
        }

        public string HowsItGoingMate()
        {
            string status = string.Empty;

            if (toxicateLevel < 4)
            {
                status = "Pour me anudder!";
            }
            else
            {
                status = "Arghh, I'ma Pirate. How d'ya d'ink its goin?";
            }

            return status;
        }
    }
}
