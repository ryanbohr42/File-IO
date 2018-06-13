using System;
using System.IO;
using System.Reflection;

namespace FileIOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EveryFifth Ef = new EveryFifth();

            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path += "/numbers.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            Ef.displayFifthNumber(lines);
            Console.ReadKey();
        }

    }
}
