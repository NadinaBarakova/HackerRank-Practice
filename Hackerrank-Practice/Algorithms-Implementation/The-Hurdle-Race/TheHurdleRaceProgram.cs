using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmImplementationHackerrank
{
    class TheHurdleRaceProgram
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int k = int.Parse(input[1]);
            List<int> height = new List<int>();

            int result = 0;

            int maxElement = height.Max();
            if (maxElement > k)
            {
                result = maxElement - k;
            }
            Console.WriteLine(result);
        }
    }
}
