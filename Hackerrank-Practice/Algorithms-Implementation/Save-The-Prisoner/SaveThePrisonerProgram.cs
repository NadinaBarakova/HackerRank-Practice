using System;
using System.Collections.Generic;

namespace SaveThePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            
            while (t != 0)
            {
                var input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                int s = int.Parse(input[2]);

                int remaining = m % n;
                
                if ((remaining+s-1)%n==0)
                {
                    Console.WriteLine(n);
                }

                else
                {
                    Console.WriteLine((remaining + s - 1) % n);
                }
                t--;
            }
        }
    }
}
