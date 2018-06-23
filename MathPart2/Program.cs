using System;

namespace MathPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            int y = 4;

            // Max
            Console.WriteLine("Max: " + Math.Max(x, y));

            //Min
            Console.WriteLine("Min: " + Math.Min(x, y));

            //Sqrt
            Console.WriteLine("Sqrt:" + Math.Sqrt(x));

            //Pow
            Console.WriteLine("Pow: " + Math.Pow(x, y));

            //PI
            Console.WriteLine("PI: " + Math.PI);
        }
    }
}
