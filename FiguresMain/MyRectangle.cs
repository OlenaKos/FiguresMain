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
    public class MyRectangle : Figure, IDraw
    {

        public override Shape GetShape()
        {
            Rectangle rect = new Rectangle();
            rect.Fill = new SolidColorBrush(Colors.Coral);
            rect.Width = this.GetSideA();
            rect.Height = this.GetSideB();
            rect.Name = "rect";

            return rect;

        }
        public MyRectangle()
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(50, 0));
            points.Add(new Point(50, 100));
            points.Add(new Point(0, 100));
            
        }
        public MyRectangle(int width, int height)
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(width, 0));
            points.Add(new Point(width, height));
            points.Add(new Point(0, height));

        }


    }
}
