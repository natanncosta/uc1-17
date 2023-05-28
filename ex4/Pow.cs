using System;

namespace ex4
{
    public class Pow : ICalc
    {
        public double Calc(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double Calc(double x)
        {
            return Math.Pow(x, 2);
        }
    }
}
