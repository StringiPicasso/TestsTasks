using AreaOfFigure.Abstracts;
using AreaOfFigure.Figures;

namespace AreaOfFigure.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateAreaCircle_3_28returned()
        {
            //arrange
            AreaOfFigure.Figures.Circle circle = new AreaOfFigure.Figures.Circle();
            List<double> sides = new List<double>() { 3 };
            double degree = 2;
            double expected = Math.PI * Math.Pow(sides[0], degree);
           
            //act
            circle.CalculateArea(sides);

            //assert
            Assert.AreEqual(expected, circle.Area);
        }
    }
}