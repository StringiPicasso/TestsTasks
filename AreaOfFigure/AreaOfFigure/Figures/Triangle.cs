using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AreaOfFigure.Abstracts;

namespace AreaOfFigure.Figures
{
    public class Triangle : Figure
    {
        private double _halhPerimeter { get; set; }

        public override void CalculateArea(List<double> sides)
        {
            Sides = sides;

            for (int i = 0; i < Sides.Count; i++)
            {
                _halhPerimeter += Sides[i];
            }

            _halhPerimeter = _halhPerimeter / 2;
            Area = Math.Sqrt(_halhPerimeter * (_halhPerimeter - Sides[0]) * (_halhPerimeter - Sides[1]) * (_halhPerimeter - Sides[2]));
        }

        public bool IsRightTriangle(List<double> sides)
        {
            return sides[0] == Math.Sqrt(Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2))
                || sides[1] == Math.Sqrt(Math.Pow(sides[2], 2) + Math.Pow(sides[0], 2))
                || sides[2] == Math.Sqrt(Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2));
        }
    }
}
