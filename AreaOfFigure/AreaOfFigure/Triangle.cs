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
        private double halhPerimeter { get; set; }

        public override double Area
        {
            get
            {
                for (int i = 0; i < Sides.Count; i++)
                {
                    halhPerimeter += Sides[i];
                }

                halhPerimeter= halhPerimeter / 2;
                double answer = Math.Sqrt(halhPerimeter * (halhPerimeter - Sides[0]) * (halhPerimeter - Sides[1]) * (halhPerimeter - Sides[2]));

                return answer;
            }
        }
    }
}
