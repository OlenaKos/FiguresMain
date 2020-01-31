using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
using System.Windows.Media.Imaging;

namespace FiguresMain
{
    class MyRhombus : Figure
    {
        public MyRhombus()
        {
            points = new List<Point>();
            points.Add(new Point(100, 0));
            points.Add(new Point(50, 100));
            points.Add(new Point(100, 200));
            points.Add(new Point(150, 100));

            Polygon rhombus = new Polygon();
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
            linearGradientBrush.StartPoint = new Point(0, 0);
            linearGradientBrush.EndPoint = new Point(1, 1);
            linearGradientBrush.GradientStops.Add(new GradientStop(Colors.Coral, 0.0));
            linearGradientBrush.GradientStops.Add(new GradientStop(Colors.Yellow, 1.0));

            rhombus.Fill = linearGradientBrush;
            rhombus.Points = new PointCollection(points);

            MyShape = rhombus;
        }
    }
}
