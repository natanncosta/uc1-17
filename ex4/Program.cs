using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Sum sum = new();
            Subtract sub = new();

            sum.Calc(1, 2);
            sub.Calc(10, 9);
            sub.Calc();
        }
    }
}
