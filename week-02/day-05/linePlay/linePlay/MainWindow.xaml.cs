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

namespace linePlay
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
            int x = 0;
            int y = 0;
            LineDrawing(foxDraw, x, y);
        }
        public void LineDrawing(FoxDraw foxdraw, double x, double y)
        {
            for (int i = 0; i < canvas.Width/10; i++)
            {
                double lineStart = x + i * 10;
                double lineEnd = y + i * 10 + 1;
                foxdraw.StrokeColor(Colors.Green);
                foxdraw.DrawLine(lineStart, canvas.Width, x, lineEnd);
            }

            for (int i = 0; i < canvas.Width/10; i++)
            {
                double lineEnd = x + i * 10;
                double lineStart = y + i * 10 + 1;
                foxdraw.StrokeColor(Colors.Pink);
                foxdraw.DrawLine(lineStart, y, canvas.Width, lineEnd);
            }
        }
    }
}
