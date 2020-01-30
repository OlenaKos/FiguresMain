using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Windows.Shapes;
using System.Windows.Media;

namespace FiguresMain
{
    [TestFixture]
    class FiguresTest
    {

        //Rectangle
        [Test]
        public static void testCalculationSideARectangle()
        {
            MyRectangle rectangle = new MyRectangle();

            Assert.AreEqual(50.0, rectangle.GetSideA());
        }

        [Test]
        public static void testCalculationSideBRectangle()
        {
            MyRectangle rectangle = new MyRectangle();

            Assert.AreEqual(100.0, rectangle.GetSideB());
        }

        [Test]
        public static void testRectangleCreation()
        {
            MyRectangle rectangle = new MyRectangle(70, 80);

            Assert.AreEqual(70.0, rectangle.GetSideA());
        }
        [Test]
        public static void testRectangleCreation2()
        {
            MyRectangle rectangle = new MyRectangle(70, 80);

            Assert.AreEqual(80.0, rectangle.GetSideB());
        }


        [Test]
        public static void testCalculationSideCTriangle()
        {
            MyTriangle triangle = new MyTriangle();

            Assert.AreEqual(200.0, Math.Round(triangle.GetSideC()));
        }


        //[Test]
        //public static void testRectangleCreation3()
        //{
        //    MyRectangle rectangle = new MyRectangle(70, 80);

        //    Shape rect = new Rectangle();
        //    rect.Fill = new SolidColorBrush(Colors.Coral);
        //    rect.Width = 70;
        //    rect.Height = 80;

        //    Assert.AreEqual(rect, rectangle.GetShape());
        //}
    }
}
