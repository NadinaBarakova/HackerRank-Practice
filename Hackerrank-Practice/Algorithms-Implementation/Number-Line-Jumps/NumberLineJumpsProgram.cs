using System;

namespace NumberLineJumps
{
    class NumberLineJumpsProgram
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int x1 = int.Parse(input[0]);
            int v1 = int.Parse(input[1]);
            int x2 = int.Parse(input[2]);
            int v2 = int.Parse(input[3]);

            int kango1 = x1 + v1;
            int kango2 = x2 + v2;
            bool flag = false;

            for (int i = 0; i < 10000; i++)
            {
                if (x1 == x2)
                {
                    flag = true;
                    break;
                }
                x1 += v1;
                x2 += v2;
            }
            if (flag)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
