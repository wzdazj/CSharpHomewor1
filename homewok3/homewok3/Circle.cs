using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Circle : ShapeBase
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override void Area()
        {
            Square = radius * radius * Math.PI;
            Console.WriteLine("圆的面积" + Square);
        }
    }
}
