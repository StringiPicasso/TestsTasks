using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigure
{
    public class CalulateAnswer
    {
        private readonly Circle _circle = new Circle();
        private readonly Triangle _triangle = new Triangle();
        private List<double> _sides = new List<double>();

        public void ProgramCalculate()
        {
            while (true)
            {
                Console.WriteLine("Enter the Value or Press the key to see the answer");

                if (TryGetNumber(out double inputText))
                {
                    _sides.Add(inputText);
                }
                else
                {
                    SearchFigure(_sides);
                }

                _sides.Clear();
            }
        }

        private void SearchFigure(List<double> sides)
        {
            switch (_sides.Count)
            {
                case 1:
                    _circle.CalculateArea(sides);
                    break;
                case 3:
                    _triangle.CalculateArea(sides);
                    break;
                default:
                    Console.WriteLine("The Figure not found");
                    break;
            }
        }

        private bool TryGetNumber(out double inputNumber)
        {
            string inputText = Console.ReadLine();

            bool isNumber = double.TryParse(inputText, out inputNumber);

            return isNumber;
        }
    }
}

