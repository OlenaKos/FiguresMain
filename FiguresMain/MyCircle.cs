﻿using System;
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
    class MyCircle : Figure
    {
        public MyCircle()
        {
            Ellipse circle = new Ellipse();
            circle.Height = 100;
            circle.Width = 100;
            circle.Fill = new SolidColorBrush(Colors.ForestGreen);

            MyShape = circle;
        }
    }
}
