using System;
using System.Collections.Generic;
using System.Linq;

namespace ScaleFocusPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> ar = Console.ReadLine().Split().Select(int.Parse).ToList();

            int matches = 0;

            List<int> copy = new List<int>(ar);

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] == ar[j] && ar[i] >= 1)
                    {
                        copy[i] = 0;
                        copy[j] = 0;
                        ar[j] = 0;
                        break;
                    }
                }
            }
            copy.RemoveAll(x => x == 0);
            matches = (ar.Count - copy.Count) / 2;
            Console.WriteLine(matches);
        }
    }
}