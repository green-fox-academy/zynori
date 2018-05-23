using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie char1 = new Sharpie("white", 120.34F);

            char1.Use();

            Console.WriteLine($"char1 is a {char1.color} dog and {char1.width} cm and inkamount: {char1.inkAmount}");
            Console.ReadLine();
        }
    }

    class Sharpie
    {
        public string color;
        public float width;
        public float inkAmount = 100;

        public Sharpie(string color, float width)
        {
            this.color = color;
            this.width = width;
        }

        public void Use()
        {
            inkAmount--;
        }
    }
}
//Create Sharpie class
//We should know about each sharpie their Color(which should be a string), Width(which will be a floating point number), InkAmount(another floating point number)
//When creating one, we need to specify the Color and the Width
//Every sharpie is created with a default 100 as InkAmount
//We can Use() the sharpie objects
//which decreases inkAmount
