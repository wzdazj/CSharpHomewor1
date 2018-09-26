using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Squares : ShapeBase

    {
        private float width;

        public Squares(float width)
        {
            this.width = width;
        }

        public override void Area()
        {
            Square = width * width;
            Console.WriteLine("正方形的面积" + Square);
        }
    }
}
