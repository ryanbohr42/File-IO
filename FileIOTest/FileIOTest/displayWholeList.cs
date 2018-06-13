using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOTest
{
    class displayWholeList
    {
        public static void DisplayWholeList(string[] numbers)
        {



            Console.WriteLine("whole list of input:");

            for (int n = 0; n < numbers.Length; n++)
            {

                Console.WriteLine(numbers[n]);

            }
        }
}
}
