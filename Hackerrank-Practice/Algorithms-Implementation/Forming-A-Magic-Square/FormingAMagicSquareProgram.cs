using System;
using System.Collections.Generic;
using System.Linq;

namespace FormingAMagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputMatrix = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToList();

                inputMatrix.Add(input);
            }

            List<List<int>> s = new(inputMatrix);

            List<List<int>> possibilities = new List<List<int>>();
            possibilities.Add(new List<int>
            {
                8,1,6,3,5,7,4,9,2
            });
            possibilities.Add(new List<int>
            {
                6,1,8,7,5,3,2,9,4
            });
            possibilities.Add(new List<int>
            {
                4,9,2,3,5,7,8,1,6
            });
            possibilities.Add(new List<int>
            {
                2,9,4,7,5,3,6,1,8
            });
            possibilities.Add(new List<int>
            {
                8,3,4,1,5,9,6,7,2
            });
            possibilities.Add(new List<int>
            {
                4,3,8,9,5,1,2,7,6
            });
            possibilities.Add(new List<int>
            {
                6,7,2,1,5,9,8,3,4
            });
            possibilities.Add(new List<int>
            {
                2,7,6,9,5,1,4,3,8
            });

            int min = int.MaxValue;

            for (int i = 0; i < possibilities.Count; i++)
            {
                int total = 0;
                for (int j = 0; j < possibilities[i].Count; j++)
                {
                    total += Math.Abs(s[j / 3][j % 3] - possibilities[i][j]);
                }
                if (total < min)
                {
                    min = total;
                }
            }
            Console.WriteLine(min);
        }
    }
}
