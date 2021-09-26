using System;
using System.Collections.Generic;
using System.Linq;

namespace JumpingOnTheCloudsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int[] c = new int[int.Parse(input[0])];
            c = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(input[1]);
            int n = c.Length;

            int energy = 100;
            
            int index = 0;
            while (index == 0 || index % n != 0)
            {
                if (c[index%n]==1)
                {
                    energy -= 2;
                }
                energy--;
                index += k;
            }


            Console.WriteLine(energy);
        }
    }
}
