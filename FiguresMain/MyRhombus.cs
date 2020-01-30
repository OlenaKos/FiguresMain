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
    class MyRhombus : Figure, IDraw
    {
        public override Shape GetShape()
        {
            Polygon rhombus = new Polygon();
            rhombus.Fill = new SolidColorBrush(Colors.DarkSlateBlue);
            rhombus.Points = new PointCollection(points);


            return rhombus;

        }
        public MyRhombus()
        {
            points = new List<Point>();
            points.Add(new Point(100, 0));
            points.Add(new Point(50, 100));
            points.Add(new Point(100, 200));
            points.Add(new Point(150, 100));

        }
    }
}
