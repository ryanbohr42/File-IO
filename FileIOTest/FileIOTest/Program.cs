using System;
using System.IO;
using System.Reflection;

namespace FileIOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = System.IO.File.ReadAllLines("C:/Users/Ryan/Documents/Ryan/Full Stack Camp/Repos/File IO/FileIOTest/numbers.txt");
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/numbers.txt";
            //path += "/numbers.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            Even.displayEvenNumbers(lines);
            Console.ReadKey();
        }

    }
}
