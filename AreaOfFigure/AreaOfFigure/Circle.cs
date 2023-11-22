namespace AreaOfFigure
{
    internal class Circle : Figure
    {
        private double _radius;

        public Circle(double radius) : base(radius)
        {
            _radius = radius;
        }

        public double CallculateCircle(double radius)
        {
            Area=Math.PI*Math.Pow(radius,2);

            return Area;
        }
    }
}
