using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
            a.Sort();
            int start = 0;
            int len = 0;
            int num = 1;

            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] - a[start] >= 2)
                {
                    num = 1;
                    len = Math.Max(len, i - start);
                    start = i;
                }
                else
                {
                    num++;
                }
            }

            Console.WriteLine(Math.Max(len, num));


        }


    }
}
