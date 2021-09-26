using System;
using System.Collections.Generic;
using System.Linq;

namespace NonDivisibleSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int k = int.Parse(input[1]);
            List<int> s = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sPrim = new List<int>();
            s.Add(0);

            for (int i = 0; i < s.Count - 1; i++)
            {
                for (int j = i + 1; j < s.Count - 1; j++)
                {
                    sPrim.Add(s[i]);
                    sPrim.Add(s[j]);
                }
            }
            Console.WriteLine(string.Join(" ",sPrim));
        }
    }
}
