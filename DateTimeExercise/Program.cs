using System;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formattedDate = "";
            //First Format: 14-06-2018 07:21:10
            formattedDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}", myDate);
            Console.WriteLine(formattedDate);

            //Second Format: Saturday of month September 2017
            formattedDate = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", myDate);
            Console.WriteLine(formattedDate);
            /*Third Format
             *Day Saturday
             *Month Setember
             *Year 2017
             */
             formattedDate = string.Format("{0:' Day' dddd \n 'Month' MMMM \n 'Year' yyyy}", myDate);
             Console.WriteLine(formattedDate);

        }
    }
}
