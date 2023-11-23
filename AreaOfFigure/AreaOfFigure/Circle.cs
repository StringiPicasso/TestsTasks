namespace AreaOfFigure
{
    internal class Circle : Figure
    {
        public double Degree { get; set; } = 2;
        public override double Area => Math.PI * Math.Pow(Sides[0], Degree);
    }
}
