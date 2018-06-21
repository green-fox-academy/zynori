using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Ship
    {
        private List<ICrewMember> crew = new List<ICrewMember>();

        public void FillShip()
        {
            Random rnd = new Random();
            int crewNumber = rnd.Next(5, 30);
            for (int i = 0; i < crewNumber; i++)
            {
                crew.Add(new Pirate());
            }

            crew.Add(new Captain());
        }

        public override string ToString()
        {
            Captain captain = GetCaptain();


            return $"Captain has drinked {captain.GetToxicateLvl()} rums and he is {(captain.IsAlive() ? "alive" : "dead")} and he is {(captain.IsPassedOut() ? "passed out" : "awake")}\n" +
                $"The ship has {GetAlivePirates().Count} pirates alive";
        }

        public bool Battle(Ship otherShip)
        {
            if (CalculateScore() > otherShip.CalculateScore())
            {
                WinBattle();
                otherShip.LostBattle();
                return true;
            } else
            {
                LostBattle();
                otherShip.WinBattle();
                return false;
            }
        }

        private void LostBattle()
        {
            Random rnd = new Random();
            int deathNums = rnd.Next(1, GetAlivePirates().Count);
            int killedNums = 0;

            foreach (var member in GetAlivePirates())
            {
                if (killedNums == deathNums)
                {
                    break;
                }
                member.Die();
                killedNums++;
            }
        }

        private void WinBattle()
        {
            Random rnd = new Random();
            int rums = rnd.Next(1, 5);
            for (int i = 0; i < rums; i++)
            {
                GetCaptain().DrinkSomeRum();
            }
        }

        public int CalculateScore()
        {
            return GetAlivePirates().Count - GetCaptain().GetToxicateLvl();
        }

        

        protected Captain GetCaptain()
        {
            Captain captain = crew.FirstOrDefault(member => member is Captain) as Captain;

            return captain;
        }

        protected List<Pirate> GetAlivePirates()
        {
            return (from crewMember in crew
                   where crewMember is Pirate && crewMember.IsAlive()
                   select crewMember as Pirate).ToList();
        }
    }
}
