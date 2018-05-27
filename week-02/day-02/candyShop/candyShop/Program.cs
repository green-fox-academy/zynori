using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace candyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            Console.WriteLine(Sweets(list));       
            Console.ReadKey();
        }

        static StringBuilder Sweets(List<object> list)
        {
            StringBuilder cakes = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetType() == typeof(int))
                {
                    cakes.Append("Croissant, ");
                }
                else if (list[i].GetType() == typeof(bool))
                {
                    cakes.Append("Ice cream, ");
                }
                else
                {
                    cakes.Append(list[i] + ", ");
                }
            }

            return cakes;
        }
    }
}
// Accidentally we added "2" and "false" to the list.
// Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
// No, don't just remove the lines
// Create a method called Sweets() which takes the list as a parameter.
// Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"