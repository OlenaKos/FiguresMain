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


        //[test]
        //public static void testrectanglecreation3()
        //{
        //    myrectangle rectangle = new myrectangle(70, 80);

        //    shape rect = new rectangle();
        //    rect.fill = new solidcolorbrush(colors.coral);
        //    rect.width = 70;
        //    rect.height = 80;

        //    assert.areequal(rect, rectangle.getshape());
        //}
    }
}
