using System;

namespace LoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Even Number ==========");
            for (int i = 0 ; i <= 501 ; i++)
            {
                if (i % 2 == 0)
                {
                    if ( i == 0)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write("," + i);   
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("========== Triangle ==========");
            for(int i = 0 ; i <= 10 ; i++)
            {
                for (int j = 0 ; j <= i ; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
        }
    }
}
