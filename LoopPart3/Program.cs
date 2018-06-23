using System;

namespace LoopPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1 ; i <= 5 ; i++)
            {
                Console.WriteLine("Frist Loop i = " + i);
                for(int j = 1 ; j <= 4 ; j++)
                {
                    Console.WriteLine("Second Loop j = " + j);
                }
                Console.WriteLine();
            }

            for (int i = 1 ; i <= 30 ; i++)
            {
                for(int j = 1 ; j <= 30 ; j++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
