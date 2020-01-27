using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresMain
{
    abstract public class Figure
    {
        public double SquareFigure { get; set; }
        public double PerimeterFigure { get; set; }

        public List<Point> points { get; set; }
        public abstract void DrawFigure(Figure figure);
        
    }
}
