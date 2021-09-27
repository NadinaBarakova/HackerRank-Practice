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

            int[] reminders = new int[k];
            for (int i = 0; i < k; i++)
            {
                reminders[i] = 0;
            }
            for (int i = 0; i < s.Count; i++)
            {
                reminders[s[i] % k]++;
            }
            if (k % 2 == 0)
            {
                reminders[k / 2] = Math.Min(reminders[k / 2], 1);
            }
            int result = Math.Min(reminders[0], 1);

            for (int i = 1; i <= k / 2; i++)
            {
                result += Math.Max(reminders[i], reminders[k - i]);
            }

            Console.WriteLine(result);
        }
    }
}
