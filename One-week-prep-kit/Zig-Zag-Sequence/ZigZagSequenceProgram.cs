using System;
using System.Linq;

namespace ZigZagSequence
{
    class ZigZagSequenceProgram
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                a = Console.ReadLine().Split().Select(int.Parse).ToArray();
                FindZigZagSequence(a, n);
            }
        }

        private static void FindZigZagSequence(int[] a, int n)
        {
            Array.Sort(a);
            int mid = n / 2;
            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st = st + 1;
                ed = ed - 1;
            }
            for (int i = 0; i < n; i++)
            {
                if (i > 0) Console.WriteLine(" ");
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
        }
    }
}
