namespace AreaOfFigure
{
    public abstract class Figure
    {
        public List<double> Sides { get; set; }
        public abstract double Area { get; }

        public void CalculateArea(List<double> sides)
        {
            Sides = sides;
            Console.WriteLine($"Area is: {Area}");
        }
    }
}