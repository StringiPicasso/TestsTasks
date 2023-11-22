using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigure
{
    internal class CalulateAnswer
    {
        private readonly Circle _circle;
        private readonly Triangle _triangle;
        string _inputString;

        public void ProgramCalculate()
        {
            Console.WriteLine("Choose number of Figure:\n1 - Circle\n2 - Triangle");
            _inputString = Console.ReadLine();

            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    CalculateCircleAnswer();
                    break;
                case ConsoleKey.D2:
                    CalculateTriangleAnswer();
                    break;
            }

            Console.ReadKey();
            Console.Clear();

        }

        private void CalculateCircleAnswer()
        {
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());

            double answer = _circle.CallculateCircle(radius);

            Console.WriteLine($"S={answer}");
        }
        private void CalculateTriangleAnswer()
        {
            double size;
            size = Convert.ToDouble(Console.ReadLine());

            _triangle.Size1 = size;
            size = Convert.ToDouble(Console.ReadLine());

            _triangle.Size2 = size;
            size = Convert.ToDouble(Console.ReadLine());

            _triangle.Size3 = size;

            double answer = _triangle.CalcilateTriangle(_triangle.Size1, _triangle.Size2, _triangle.Size3);

            Console.WriteLine($"S={answer}");
        }
    }
}

