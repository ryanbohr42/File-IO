using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOTest
{
    class Even
    {

        public static void displayEvenNumbers(string[] lines)
        {
            foreach (string line in lines)
            {
                if (Int32.Parse(line)%2 == 0)
                    Console.WriteLine(Int32.Parse(line));
            }
            Console.ReadKey();
        }
    }
}
