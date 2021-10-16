using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingSort1
{
    class CountingSort1Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] result = new int[100];
            for (int i = 0; i < 100; i++)
            {
                result[i] = 0;
            }
            int item = 1;

            int x = arr.Count / 100;
            while (x > 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (result[arr[i]] == 0)
                    {
                        result[arr[i]] = item;
                    }
                    else if (result[arr[i]] != 0)
                    {
                        result[arr[i]] += item;
                        item = 1;
                    }
                }
                arr.RemoveRange(0, 100);
                x--;
            }
            Console.WriteLine(string.Join(" ", result.ToList()));

        }
    }
}
