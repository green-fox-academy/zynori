using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    interface ICrewMember
    {
        bool IsAlive();
        bool IsPassedOut();
        int GetToxicateLvl();

        void DrinkSomeRum();
        void Sleep();
        void Die();
        void Brawl(Pirate otherPirate);
        string HowsItGoingMate();
    }
}
