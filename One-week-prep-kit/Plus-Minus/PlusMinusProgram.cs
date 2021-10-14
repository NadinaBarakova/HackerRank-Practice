using System;
using System.Collections.Generic;
using System.Linq;

namespace OneWeekPreparationKit
{
    class PlusMinusProgram
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();


            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                if (arr[i] < 0)
                {
                    negativeCount++;
                }
                if (arr[i] == 0)
                {
                    zeroCount++;
                }
            }
            decimal positive = (decimal)positiveCount / arr.Count*1.000000M;
            decimal negative = (decimal)negativeCount / arr.Count * 1.000000M;
            decimal zero = (decimal)zeroCount / arr.Count * 1.000000M;

            positive = Math.Round(positive, 6);
            negative = Math.Round(negative, 6);
            zero = Math.Round(zero, 6);

            Console.WriteLine(positive);
            Console.WriteLine(negative);
            Console.WriteLine(zero);

        }
    }
}
