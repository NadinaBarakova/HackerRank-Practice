using System;
using System.Collections.Generic;
using System.Linq;

namespace SubarrayDivision
{
    class SubarrayDivisionProgram
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine().Split();

            var d = int.Parse(input[0]);
            var m = int.Parse(input[1]);
            int count = 0;
            List<int> sum = new List<int>();

            for (int i = 0; i < s.Count; i++)
            {
                if (s[i] == d && m > s.Count)
                {
                    count++;
                }
                else
                {
                    if (m + i > s.Count)
                    {
                        break;
                    }
                    for (int j = i; j < m + i; j++)
                    {
                        sum.Add(s[j]);
                    }
                    if (sum.Sum() == d)
                    {
                        count++;
                    }
                    sum.Clear();

                }
            }

            Console.WriteLine(count);
        }
    }
}
