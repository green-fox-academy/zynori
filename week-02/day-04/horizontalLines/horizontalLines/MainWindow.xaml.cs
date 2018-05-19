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

namespace horizontalLines
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
            int x = 10;
            int y = 40;

            LineDrawing(foxDraw, x, y);
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // Draw 3 lines with that function. Use loop for that.
        }

        private void LineDrawing(FoxDraw foxDraw, int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
                foxDraw.StrokeColor(Colors.IndianRed);
                foxDraw.DrawLine(x, y += 50, x += 50, y);
            }
        }
    }
}
