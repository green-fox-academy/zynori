using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class BattleApp
    {
        public BattleApp()
        {
            Ship ship1 = new Ship();
            Ship ship2 = new Ship();
            ship1.FillShip();
            ship2.FillShip();

            Console.WriteLine(ship1);
            Console.WriteLine(ship2);

            BattleShips(ship1, ship2);

            Console.ReadLine();
        }

        protected void BattleShips(Ship ship1, Ship ship2)
        {
            ship1.Battle(ship2);
            Console.WriteLine(ship1);
            Console.WriteLine(ship2);
        }
    }
}
