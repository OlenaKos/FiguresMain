using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Input;

namespace FiguresMain
{
    class MyEllipse : Figure
    {
        public MyEllipse()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Height = 50;
            ellipse.Width = 100;
            ellipse.Fill = new SolidColorBrush(Colors.Violet);

            MyShape = ellipse;
        }

 
    }
}
