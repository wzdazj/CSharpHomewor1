using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Text;

namespace homework3
{
    abstract class ShapeBase
    {
        private double square;

        public double Square
        {
            get { return square; }
            set { square = value; }
        }

        public abstract void Area();
    }
}