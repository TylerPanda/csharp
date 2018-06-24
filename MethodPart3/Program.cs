using System;

namespace MethodPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstEmployee, secondEmployee;

            firstEmployee = "David Smith";
            secondEmployee = "Sophia Waston";

            Console.WriteLine($"Inside Main Method\n----------\n{firstEmployee}\n{secondEmployee}\n\n");
            changNames(ref firstEmployee, ref secondEmployee);

            Console.WriteLine($"Inside Main Method\n----------\n{firstEmployee}\n{secondEmployee}\n\n");
        }

        static void changNames(ref string firstEmployee, ref string secondEmployee)
        {
            firstEmployee = "Olivia Aaron";
            secondEmployee = "Alvaro Salazar";
            Console.WriteLine($"Outside Main Method\n----------\n{firstEmployee}\n{secondEmployee}\n\n");
        }
    }
}
