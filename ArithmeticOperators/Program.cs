using System;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = 6;
            // int y = 2;
            // int results = 0;
            //
            // results = x / y;
            // Console.WriteLine("Rem:" + results);

            int x, y;
            int add, sub, mult, rem;
            float div;

            Console.WriteLine("Enter no. 1");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter no. 2");
            y = int.Parse(Console.ReadLine());

            add = x + y;
            Console.WriteLine(x + " + " + y + " = "  + add);

            sub = x - y;
            Console.WriteLine(x + " - " + y + " = "  + sub);

            mult = x * y;
            Console.WriteLine(x + " * " + y + " = "  + mult);

            div = (float)x / (float)y;
            Console.WriteLine(x + " / " + y + " = "  + div);

            rem = x % y;
            Console.WriteLine(x + " % " + y + " = "  + rem);

            // int y = 0;
            x = 2 + 3 * 2 - 4 + 2;
            Console.WriteLine(x);

        }
    }
}
