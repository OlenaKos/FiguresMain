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
    class MySquare : Figure, IDraw
    {
        public override Shape GetShape()
        {
            Rectangle rect = new Rectangle();
            rect.Fill = new SolidColorBrush(Colors.Yellow);
            rect.Width = GetSideA();
            rect.Height = GetSideA();

            return rect;

        }
        public MySquare()
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(50, 0));
            points.Add(new Point(50, 50));
            points.Add(new Point(0, 50));

        }
        public MySquare(int width)
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(width, 0));
            points.Add(new Point(width, width));
            points.Add(new Point(0, width));

        }
    }
}
