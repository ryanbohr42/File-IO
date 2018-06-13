using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOTest
{
    static class DivisibleBy3
    {
        public static List<int> Ints(string[] lines)
        {
            int[] numbers = new int[lines.Length];
            int i = 0;
            for (i = 0; i < lines.Length; i++){
                int conversion = int.Parse(lines[i]);
                numbers[i] = conversion;
            }
            List<int> threes = new List<int>();
            for(i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    threes.Add(numbers[i]);
                }
            }
            return threes;
        }
    }
}
