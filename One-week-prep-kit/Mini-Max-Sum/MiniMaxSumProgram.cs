using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace MiniMaxSum
{
    class MiniMaxSumProgram
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            long min = long.MinValue;
            long max = long.MaxValue;
            long sumMin = 0;
            long sumMax = 0;
            List<int> copyArr = new List<int>(arr);

            List<int> dist = new List<int>(arr.Distinct());
            if (dist.Count == 1)
            {
                sumMax = sumMin = dist[0] * 4;
            }
            else
            {
                while (arr.Count > 1 || copyArr.Count > 1)
                {
                    if (arr.Min() > min)
                    {
                        min = arr.Min();
                        sumMin += min;
                        arr.Remove(arr.Min());
                    }
                    if (copyArr.Max() < max)
                    {
                        max = copyArr.Max();
                        sumMax += max;
                        copyArr.Remove(copyArr.Max());
                    }
                }
            }

            List<long> result = new List<long>();
            result.Add(sumMin);
            result.Add(sumMax);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
