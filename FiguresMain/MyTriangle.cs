using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace FiguresMain
{
   public class MyTriangle : Figure, IDraw
    {

        public override Shape GetShape()
        {
            Polygon triangle = new Polygon();
            triangle.Fill = new SolidColorBrush(Colors.Coral);
            triangle.Points = new PointCollection(points);


            return triangle;

        }
        public MyTriangle()
        {
            points = new List<Point>();
            points.Add(new Point(50, 150));
            points.Add(new Point(150, 50));
            points.Add(new Point(250, 150));

        }
        public MyTriangle(int width, int height)
        {
            points = new List<Point>();
            points.Add(new Point(50, 150));
            points.Add(new Point(150, 50));
            points.Add(new Point(250, 150));

        }

        public double GetSideC()
        {
            double SideB = Math.Sqrt(Math.Pow((points[2].X - points[0].X), 2) + Math.Pow((points[2].Y - points[0].Y), 2));

            return SideB;
        }
    }
}
