using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var keyboards = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var drives = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int b = input[0];

            var sums = 0;

            var results = new List<int>();

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    sums = keyboards[i] + drives[j];
                    results.Add(sums);
                }
            }
            results.Sort();
            results.Reverse();
            var result = results.FirstOrDefault(s => s <= b);
            if (result == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(result);
            }

        }
    }
}
