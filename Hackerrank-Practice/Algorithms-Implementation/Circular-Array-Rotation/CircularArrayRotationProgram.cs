using System;
using System.Collections.Generic;
using System.Linq;

namespace CircularArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int k = int.Parse(input[1]);
            int q = int.Parse(input[2]);

            List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> queries = new List<int>();

            for (int i = 0; i < q; i++)
            {
                int queriesItem = int.Parse(Console.ReadLine());
                queries.Add(queriesItem);
            }
            List<int> result = CircularArrayRotation(a, k, queries);
         
            Console.WriteLine(string.Join(" ", result));

        }

        private static List<int> CircularArrayRotation(List<int> a, int k, List<int> queries)
        {
            k = k % a.Count;
            int[] arr = new int[a.Count];
            List<int> result = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                int index = (i + k) % a.Count;
                arr[index] = a[i];
            }

            for (int i = 0; i < queries.Count; i++)
            {
                result.Add(arr[queries[i]]);
            }
            return result;
        }

   
    }
}
