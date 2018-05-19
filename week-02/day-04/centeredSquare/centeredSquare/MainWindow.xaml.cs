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

namespace centeredSquare
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
            DrawSquare(foxDraw);
            // Draw a green 10x10 square to the canvas' center.
        }

        public void DrawSquare(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width / 2 + 10, canvas.Height / 2 + 10, canvas.Width / 2 + 20, canvas.Height / 2 + 10);
            foxDraw.DrawLine(canvas.Width / 2 + 10, canvas.Height / 2 + 20, canvas.Width / 2 + 20, canvas.Height / 2 + 20);
            foxDraw.DrawLine(canvas.Width / 2 + 10, canvas.Height / 2 + 20, canvas.Width / 2 + 10, canvas.Height / 2 + 10);
            foxDraw.DrawLine(canvas.Width / 2 + 20, canvas.Height / 2 + 10, canvas.Width / 2 + 20, canvas.Height / 2 + 20);
        }
    }
}
