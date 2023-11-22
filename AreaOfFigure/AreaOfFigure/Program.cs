using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AreaOfFigure
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            CalulateAnswer answer = new CalulateAnswer();

            answer.ProgramCalculate();
        }

    }
}
