using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresMain
{
   public class Triangle : Figure
    {
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override void DrawFigure(Figure figure)
        {
            throw new NotImplementedException();
        }
    }
}
