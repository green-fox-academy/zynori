using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoPrints
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";

            int games = todoText.IndexOf("milk\n");
            string indexGames = todoText.Insert(games + "milk\n".Length, " - Download games\n" + "\t- Diablo");

            todoText = indexGames;
            
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine("My todo:\n" + todoText);
            Console.ReadLine();
        }
    }
}
