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

namespace coloredBox
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
            DrawGreenLines(foxDraw);
            // Draw a box that has different colored lines on each edge.
        }

        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(100, 100, 200, 100);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(200, 100, 200, 200);
            foxDraw.StrokeColor(Colors.HotPink);
            foxDraw.DrawLine(100, 200, 200, 200);
            foxDraw.StrokeColor(Colors.DodgerBlue);
            foxDraw.DrawLine(100, 200, 100, 100);
        }
    }
}
