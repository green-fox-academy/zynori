using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal horse = new Animal(50, 50);
            horse.Eat();
            horse.Drink();
            horse.Play();
            Console.WriteLine($"Thirst level of your horse: {horse.numberOfThirst}");
            Console.WriteLine($"Hunger level of your horse: {horse.numberOfHunger}");
            Console.ReadLine();
        }
    }

    class Animal
    {
        public int numberOfHunger;
        public int numberOfThirst;

        public Animal(int numberOfHunger, int numberOfThirst)
        {
            this.numberOfHunger = numberOfHunger;
            this.numberOfThirst = numberOfThirst;
        }

        public void Eat()
        {
            numberOfHunger--;
        }

        public void Drink()
        {
            numberOfThirst--;
        }

        public void Play()
        {
            numberOfHunger++;
            numberOfThirst++;
        }
    }
}
