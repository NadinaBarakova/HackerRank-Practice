using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            EextraLongFactorials(n);

        }
        public static void EextraLongFactorials(int n)
        {
            BigInteger result = 1;
            for (int i = 0; i < n; i++)
            {
                BigInteger res = (n - i);
                result *= res;
            }
            Console.WriteLine(result);
        }
        static BigInteger FactorialN(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * FactorialN(n - 1);
        }
    }
}
