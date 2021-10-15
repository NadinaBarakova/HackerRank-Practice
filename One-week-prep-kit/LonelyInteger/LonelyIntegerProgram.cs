using System;
using System.Collections.Generic;
using System.Linq;

namespace LonelyInteger
{
    class LonelyIntegerProgram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
            a.Add(-1);
            a.Sort();
            a.Reverse();
            int result = 0;

            for (int i = 0; i < a.Count; i += 2)
            {
                if (a[i] != a[i + 1] || (a[i] == a[a.Count - 2] && a[i] != a[i - 1]))
                {
                    result =a [i];
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
