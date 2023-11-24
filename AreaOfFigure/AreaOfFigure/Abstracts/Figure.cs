using System.Diagnostics;

namespace AreaOfFigure.Abstracts
{
    public abstract class Figure
    {
        public List<double> Sides { get; set; }
        public double Area { get; set; }

        public abstract void CalculateArea(List<double> sides);
    }
}