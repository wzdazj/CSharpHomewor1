using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework3
{
    class Rectangle : ShapeBase
    {
        private double width, high;

        public Rectangle(double width, double high)
        {
            this.width = width;
            this.high = high;
        }

        public override void Area()
        {
            Square = width * high;
            Console.WriteLine("长方形的面积" + Square);
        }
    }
}
