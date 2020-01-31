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
    public class MyRectangle : Figure
    {

        public MyRectangle()
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(50, 0));
            points.Add(new Point(50, 100));
            points.Add(new Point(0, 100));

            Polygon rect = new Polygon();
            rect.Fill = new SolidColorBrush(Colors.Chartreuse);
            rect.Points = new PointCollection(points);

            MyShape = rect;

        }
        public MyRectangle(int width, int height)
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(width, 0));
            points.Add(new Point(width, height));
            points.Add(new Point(0, height));

            Polygon rect = new Polygon();
            rect.Fill = new SolidColorBrush(Colors.Chartreuse);
            rect.Points = new PointCollection(points);

            MyShape = rect;

        }


    }
}
