using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresMain
{
    public class MyRectangle : Figure
    {

        public override void DrawFigure(Figure figure)
        {
            throw new NotImplementedException();
        }
        public MyRectangle()
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(50, 0));
            points.Add(new Point(50, 100));
            points.Add(new Point(0, 100));
        }

        public double GetSideB()
        {
            double SideB = Math.Sqrt(Math.Pow((points[2].x - points[1].x), 2) + Math.Pow((points[2].y - points[1].y), 2));

            return SideB;
        }
        public double GetSideA()
        {
            double SideA = Math.Sqrt(Math.Pow((points[1].x - points[0].x), 2) + Math.Pow((points[1].y - points[0].y), 2));

            return SideA;
        }
    }
}
