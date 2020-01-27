using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresMain
{
    public class Point
    {
        public double x { set; get; }
        public double y { set; get; }

        public Point(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
    }
}
