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
    class MySquare : Figure
    {
        public MySquare()
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(90, 0));
            points.Add(new Point(90, 50));
            points.Add(new Point(0, 50));

            Polygon rect = new Polygon();
            rect.Fill = new SolidColorBrush(Colors.Yellow);
            rect.Points = new PointCollection(points);

            MyShape = rect;

        }
        public MySquare(int width)
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(width, 0));
            points.Add(new Point(width, width));
            points.Add(new Point(0, width));

            Polygon rect = new Polygon();
            rect.Fill = new SolidColorBrush(Colors.Yellow);
            rect.Points = new PointCollection(points);

            MyShape = rect;

        }
    }
}
