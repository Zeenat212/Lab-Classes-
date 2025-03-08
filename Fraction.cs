using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    internal class Fraction
    {
        public int Dividend;
        public int Divisor;

        public Fraction(int dividend, int divisor)
        {
            Dividend = dividend;
            Divisor = divisor;
        }

        public void ShowFraction()
        {
            Console.WriteLine(Dividend + "/" + Divisor);
        }

    }
}
