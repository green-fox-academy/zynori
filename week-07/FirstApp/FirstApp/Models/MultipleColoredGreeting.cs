using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class MultipleColoredGreeting
    {
        public string[] hellos;
        public string Name { get; set; }

        public MultipleColoredGreeting()
        {
            hellos = new string[] 
            {
                "Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
                "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
                "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
                "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"
            };
        }

        public int GetFontSize()
        {
            Random rndFont = new Random();
            return rndFont.Next(10, 60);

        }

        public int GetColor()
        {
            Random rndColor = new Random();
            return rndColor.Next(0, 256);
        }
    }
}
