using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    class BetweenTwoSetsProgram
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> b = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int counter = 0;

            for (int i = a.Max(); i <= b.Min() + 1; i++)
            {
                bool isFacorMultiple = true;
                foreach (var item in a)
                {
                    if (i % item != 0)
                    {
                        isFacorMultiple = false;
                        break;
                    }
                }
                foreach (var item in b)
                {
                    if (item % i != 0)
                    {
                        isFacorMultiple = false;
                        break;
                    }
                }
                if (isFacorMultiple)
                {
                    counter++;
                }

            }

            Console.WriteLine(counter);
        }
    }
}
