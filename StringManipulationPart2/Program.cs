﻿using System;

namespace StringManipulationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "Game of Thrones";
            
            //Index of
            Console.WriteLine(tvShow.IndexOf('o'));

            //Last index of
            Console.WriteLine(tvShow.LastIndexOf('o'));

            //Substring
            Console.WriteLine(tvShow.Substring(5, 2));

            //Remove
            Console.WriteLine(tvShow.Remove(4));

            //Insert
            Console.WriteLine(tvShow.Insert(0, "The "));
        }
    }
}
