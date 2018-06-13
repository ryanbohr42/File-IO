using System;
using System.IO;
using System.Reflection;

namespace FileIOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path += "/numbers.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            EveryFifth.displayFifthNumber(lines);
            Console.ReadKey();
        }

    }
}
