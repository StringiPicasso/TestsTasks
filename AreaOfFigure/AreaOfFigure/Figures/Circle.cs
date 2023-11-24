using AreaOfFigure.Abstracts;

namespace AreaOfFigure.Figures
{
    public class Circle : Figure
    {
        private double Degree { get; set; } = 2;

        public override void CalculateArea(List<double> sides)
        {
            Sides = sides;
            Area = Math.PI * Math.Pow(Sides[0], Degree);
        }
    }
}
