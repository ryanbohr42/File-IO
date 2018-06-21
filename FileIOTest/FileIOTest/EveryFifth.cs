using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOTest
{
    class EveryFifth
    {
        public EveryFifth()
        {
        }

        public static void displayFifthNumber(string[] nums)
        {
            Console.WriteLine("Every Fifth Number:");
            var counter = 4;
            while (counter < nums.Length)
            {
                Console.WriteLine(nums[counter]);
                counter += 5;
            }

        }
    }
}
