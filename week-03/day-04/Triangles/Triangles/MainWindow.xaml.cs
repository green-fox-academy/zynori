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

namespace Triangles
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
            DrawTriangle(foxDraw);
           //DrawTriangle(10, new List<Point>(0, 0), new List<Point>(0, 0), new List<Point>(0, 0));
            
        }

        public void DrawTriangle(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(0, 210));
            points.Add(new Point(0, 190));
            points.Add(new Point(200, 40));
            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);



        }

        //public void ListToPointCollection(int level, List<Point> topPoint, List<Point> leftPoint, List<Point> rightPoint)
        //{
        //    var foxDraw = new FoxDraw(canvas);

        //    if (level == 0)
        //    {
        //        points[] = { topPoint, leftPoint, rightPoint };
        //    }
        //    else
        //    {
        //        List<Point> leftMid = new List<Point>();
        //        List<Point> rightMid = new List<Point>();
        //        List<Point> bottomMid = new List<Point>();

        //        rightMid.Add((topPoint.X + rightPoint.X) / 2, (topPoint.Y + rightPoint.Y) / 2);
        //        leftMid.Add((topPoint.X + leftPoint.X) / 2, (topPoint.Y + leftPoint.Y) / 2);
        //        bottomMid.Add((leftPoint.X + rightPoint.X) / 2, (topPoint.Y + rightPoint.Y) / 2);

        //        foxDraw.DrawPolygon(topPoint, leftPoint, bottomMid);

        //        DrawTriangle(level - 1, topPoint, leftMid, rightMid);
        //        DrawTriangle(level - 1, leftMid, leftPoint, bottomMid);
        //        DrawTriangle(level - 1, rightMid, bottomMid, rightPoint);
        //    }
        //}
    }
}
