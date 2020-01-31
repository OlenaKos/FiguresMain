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
    class MyTrapeze : Figure
    {
        public MyTrapeze()
        {
            points = new List<Point>();
            points.Add(new Point(50, 0));
            points.Add(new Point(150, 0));
            points.Add(new Point(175, 50));
            points.Add(new Point(25, 50));

            Polygon trapeze = new Polygon();
            trapeze.Fill = new SolidColorBrush(Colors.CornflowerBlue);
            trapeze.Points = new PointCollection(points);

            MyShape = trapeze;

        }
    }
}
