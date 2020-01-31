using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows;

namespace FiguresMain
{
    abstract public class Figure
    {
        public double SquareFigure { get; set; }
        public double PerimeterFigure { get; set; }

        public List<Point> points { get; set; }

        public Shape MyShape { get; set; }

        public double GetSideB()
        {
            double SideB = Math.Sqrt(Math.Pow((points[2].X - points[1].X), 2) + Math.Pow((points[2].Y - points[1].Y), 2));

            return SideB;
        }
        public double GetSideA()
        {
            double SideA = Math.Sqrt(Math.Pow((points[1].X - points[0].X), 2) + Math.Pow((points[1].Y - points[0].Y), 2));

            return SideA;
        }

    }
}
