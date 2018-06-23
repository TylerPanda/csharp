using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gravityForce = 9.8;
            double PI = 3.14159265359;

            gravityForce = 1;

            Console.WriteLine("Gravity force is " + gravityForce + " and PI is " + PI);
        }
    }
}
