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

        public void displayFifthNumber(string[] nums)
        {
            
            var counter = 4;
            while (counter < nums.Length)
            {
                Console.WriteLine(nums[counter]);
                counter += 5;
            }

        }
    }
}
