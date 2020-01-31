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
    class MyParallelogram : Figure
    {

        public MyParallelogram()
        {
            points = new List<Point>();
            points.Add(new Point(25, 0));
            points.Add(new Point(175, 0));
            points.Add(new Point(150, 50));
            points.Add(new Point(0, 50));

            Polygon parallelogram = new Polygon();
            parallelogram.Fill = new SolidColorBrush(Colors.Fuchsia);
            parallelogram.Points = new PointCollection(points);

            MyShape = parallelogram;

        }
    }
}
