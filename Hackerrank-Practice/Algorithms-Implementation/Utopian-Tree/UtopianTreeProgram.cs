using System;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(UtopianTr(n));
            }
        }

        private static int UtopianTr(int n)
        {
            int h = 0;

            if (n == 0)
            {
                h = 1;
            }

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    h = 1;
                }
                if (i % 2 == 0)
                {
                    h *= 2;
                }
                else
                {
                    h += 1;
                }
            }

            return h;
        }
    }
}
