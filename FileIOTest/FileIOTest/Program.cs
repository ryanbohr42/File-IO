﻿using System;
using System.IO;
using System.Reflection;

namespace FileIOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = System.IO.File.ReadAllLines("C:/Users/Ryan/Documents/Ryan/Full Stack Camp/Repos/File IO/FileIOTest/numbers.txt
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path += "/numbers.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Odds.displayOdds(lines);
            Odds.displaySums(lines);
            Console.ReadKey();
        }

    }
}
