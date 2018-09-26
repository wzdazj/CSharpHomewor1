using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Triangle : ShapeBase
    {
        private double width, high;

        public Triangle(double width, double high)
        {
            this.width = width;
            this.high = high;
        }

        public override void Area()
        {
            Square = width * high * 0.5;
            Console.WriteLine("三角形的面积" + Square);
        }
    }
}

