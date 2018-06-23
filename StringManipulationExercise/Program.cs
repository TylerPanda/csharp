using System;

namespace StringManipulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "Game of thrones      ";
            string seasonOne = " - Season 1";
            string newName = "";

            //Add " - Season 1"
            //without you determining the start index

            newName = tvShow.Insert(tvShow.Length, seasonOne);
            Console.WriteLine(newName);
            newName = tvShow.Insert(tvShow.Trim().Length, seasonOne);
            Console.WriteLine(newName);
        }
    }
}
