using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigure
{
    internal class Triangle : Figure
    {
        public Triangle(double size1, double size2, double size3) : base(size1, size2, size3)
        {
           
        }


        public double CalcilateTriangle(double size1, double size2, double size3)
        {
            double halhPerimeter = (size1 + size2 + size3) / 2;

            Area = Math.Sqrt(halhPerimeter * (halhPerimeter - size1) * (halhPerimeter - size2) * (halhPerimeter - size3));

            return Area;
        }
        
    }
}
