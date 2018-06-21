using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirate : ICrewMember
    {
        private bool isAlive;
        private bool isPassedOut;
        private int toxicateLvl;

        public bool IsAlive()
        {
            return isAlive;
        }

        public bool IsPassedOut()
        {
            return isPassedOut;
        }

        public int GetToxicateLvl()
        {
            return toxicateLvl;
        }

        public Pirate(bool isAlive = true, bool isPassedOut = false, int toxicateLvl = 0)
        {
            this.isAlive = isAlive;
            this.isPassedOut = isPassedOut;
            this.toxicateLvl = toxicateLvl;
        }

        public void DrinkSomeRum()
        {
            if (!isAlive)
            {
                throw new Exception("He's dead");
            }

            toxicateLvl++;
        }

        public void Sleep()
        {
            toxicateLvl = 0;
            isPassedOut = true;
        }

        public void Die()
        {
            isAlive = false;
        }

        public void Brawl(Pirate otherPirate)
        {
            if (!isAlive || isPassedOut || !otherPirate.isAlive || otherPirate.isPassedOut)
            {
                return;
            }

            Random rnd = new Random();
            int result = rnd.Next(1, 4);

            if (result == 1)
            {
                Die();
            }
            else if (result == 2)
            {
                otherPirate.Die();
            }
            else
            {
                Sleep();
                otherPirate.Sleep();
            }
        }

        public string HowsItGoingMate()
        {
            string status = string.Empty;

            if (toxicateLvl < 5)
            {
                status = "Pour me anudder!";
            }
            else
            {
                status = "Arghh, I'ma Pirate. How d'ya d'ink its goin?";
                Sleep();
            }

            return status;
        }

        
    }
}
