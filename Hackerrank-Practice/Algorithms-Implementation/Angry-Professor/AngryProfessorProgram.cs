using System;
using System.Collections.Generic;
using System.Linq;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            while (t > 0)
            {
                var input = Console.ReadLine().Split();
                int k = int.Parse(input[1]);
                List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
              
                List<int> b = a.Where(x => x <= 0).ToList();
                if (b.Count > k)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                t--;
            }

        }
    }
}
