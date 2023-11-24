using System.Diagnostics;
using AreaOfFigure.Figures;

namespace AreaOfFigure.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateAreaTriangle_20and13and11_66returned()
        {
            //arrange
            Triangle triangle = new Triangle();
            List<double> sides = new List<double>() {20,13,11};
            double expected = 66;

            //act
            triangle.CalculateArea(sides);

            //assert
            Assert.AreEqual(expected, triangle.Area);

        }

        [TestMethod]
        public void IsRightTriangle_trueReturned()
        {
            //arrange
            AreaOfFigure.Figures.Triangle triangle = new AreaOfFigure.Figures.Triangle();
            List<double> sides = new List<double>() { 3, 4, 5 };

            //act
            bool isRight = triangle.IsRightTriangle(sides);

            //assert
            Assert.IsTrue(isRight);
        }
    }
}