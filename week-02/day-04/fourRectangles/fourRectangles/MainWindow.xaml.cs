using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFExample;

namespace fourRectangles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRectangle(foxDraw);
            // draw four different size and color rectangles.
            // avoid code duplication.
        }

        public void Rectangle(FoxDraw foxDraw)
        {
            Random location = new Random();

            for (int i = 1; i < 4; i++)
            {
                foxDraw.DrawRectangle((location.Next((int)canvas.Width) - 7), (location.Next((int)canvas.Height -7), 350, 100);
                foxDraw.FillColor(Colors.Fuchsia);
            }
        }
    }
}
