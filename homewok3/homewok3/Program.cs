using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(4);
            Squares mySquares = new Squares(4);
            Triangle myTriangle = new Triangle(4, 4);
            Rectangle myRectangle = new Rectangle(4, 2);
            myCircle.Area();
            mySquares.Area();
            myTriangle.Area();
            myRectangle.Area();
        }
    }
}

