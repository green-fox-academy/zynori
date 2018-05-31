using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Garden
    {
        private List<Plant> plants;
        
        public Garden(List<Plant> plants)
        {
            this.plants = plants;
        }

        public void AddPlant(Plant plant)
        {
            plants.Add(plant);
        }
        
        public List<string> GetStatus()
        {
            List<string> result = new List<string>();

            foreach (Plant plant in plants)          
            {
                string status;

                if (plant.NeedWater())
                {
                    status = "needs water";
                }
                else
                {
                    status = "doesn't need water";
                }

                result.Add($"The {plant.Color} {plant.GetType()} {status}.");
            }

            return result;
        }
        
        public void Watering(double waterAmount)
        {
            int thirstyPlants = 0;

            foreach (Plant plant in plants)
            {
                if (plant.NeedWater())
                {
                    thirstyPlants++;
                }
            }

            double waterPerPlant = waterAmount / thirstyPlants;

            foreach (Plant plant in plants)
            {
                if (plant.NeedWater())
                {
                    plant.Watering(waterPerPlant);
                }
            }
        }
    }
}
