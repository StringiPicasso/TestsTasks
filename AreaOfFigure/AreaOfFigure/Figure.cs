namespace AreaOfFigure
{
    public class Figure
    {
        public double Size1 { get; set; }
        public double Size2 { get; set; }
        public double Size3 { get; set; }
        public double Area { get; set; }

        public Figure(double radius)
        {
            Size1 = radius;
        }

        public Figure(double size1, double size2, double size3)
        {
            Size1 = size1;
            Size2 = size2;
            Size3 = size3;
        }
    }
}