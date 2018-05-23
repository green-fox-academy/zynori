using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postItFirst = new PostIt("orange", "Idea 1", "blue");
            PostIt postItSecond = new PostIt("pink", "Awesome", "black");
            PostIt postItThird = new PostIt("yellow", "Superb!", "green");
        }
    }

    class PostIt
    {
        public string backgroundColor;
        public string text;
        public string textColor;
   
        public PostIt(string backgroundColor, string text, string textColor)
        {
            this.backgroundColor = backgroundColor;
            this.text = text;
            this.textColor = textColor;
        }
    }
}
