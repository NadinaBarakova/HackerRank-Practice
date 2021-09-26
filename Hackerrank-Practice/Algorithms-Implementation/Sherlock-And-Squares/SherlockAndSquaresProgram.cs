using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndSquares
{
    class SherlockAndSquaresProgram
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            while (q != 0)
            {
                var input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                Console.WriteLine(Squares(a, b));
                q--;
            }
        }

        private static int Squares(int a, int b)
        {
            int counter = 0;

            while (a <= b)
            {
                if (Math.Sqrt(a) % 1 == 0)
                {
                    a += ((int)Math.Sqrt(a) * 2 + 1);
                    counter++;
                    continue;
                }
                a++;
            }

            return counter;
        }
    }
}
