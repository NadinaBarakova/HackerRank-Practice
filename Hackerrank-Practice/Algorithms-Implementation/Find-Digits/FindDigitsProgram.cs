using System;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t != 0)
            {
                int n = int.Parse(Console.ReadLine());
                int result = FindDigits(n);
                Console.WriteLine(result);
                t--;
            }
        }

        private static int FindDigits(int n)
        {
            int count = 0;
            int length = 0;
            int temp = n;

            while (temp != 0)
            {
                temp = temp / 10;
                length++;
            }
            int digit = 0;
            int temporary = n;
            for (int i = length; i >= 1; i--)
            {
                if (i == length)
                {
                    digit = temporary % 10;
                    temporary = temporary - temporary % 10;
                    temporary /= 10;
                }
                else
                {
                    //temporary = temporary - temporary % 10;
                    digit = temporary % 10;
                    temporary /= 10;
                }
                if (digit == 0)
                {
                    continue;
                }
                if (n % digit == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
