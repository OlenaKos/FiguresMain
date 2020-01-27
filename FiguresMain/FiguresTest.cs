using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

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

            Assert.AreEqual(5, rectangle.GetSideA());
        }

        [Test]
        public static void testCalculationSideBRectangle()
        {
            MyRectangle rectangle = new MyRectangle();

            Assert.AreEqual(10, rectangle.GetSideB());
        }


    }
}
