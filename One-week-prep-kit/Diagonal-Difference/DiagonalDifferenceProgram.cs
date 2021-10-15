using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifferenceProgram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().Split().Select(int.Parse).ToList());

            }

            int primeryD = arr[0][0];
            int secondaryD = arr[0][n-1];

            for (int row = 0; row < n; row++)
            {
                for (int col = row; col <= row; col++)
                {
                    if (row + 1 == n || col + 1 == n)
                    {
                        break;
                    }
                    primeryD += arr[row + 1][col + 1];
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = n - row - 1; col >= n - row - 1; col--)
                {
                    if (row + 1 == n || col - 1 == -1)
                    {
                        break;
                    }
                    secondaryD += arr[row + 1][col - 1];

                }
            }
            Console.WriteLine(primeryD);
            Console.WriteLine(secondaryD);
            Console.WriteLine(Math.Abs(primeryD - secondaryD));
        }
    }
}
