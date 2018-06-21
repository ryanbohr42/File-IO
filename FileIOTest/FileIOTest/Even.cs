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
                if (int.Parse(line)%2 == 0)
                    Console.WriteLine(int.Parse(line));
            }
            Console.ReadKey();
        }
    }
}
