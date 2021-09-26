using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingTheLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> ranked = Console.ReadLine().Split().Select(int.Parse).ToList();
            int m = int.Parse(Console.ReadLine());
            List<int> player = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            List<int> indexes = RankIndexes(ranked);


            for (int i = 0; i < player.Count; i++)
            {
                if (player[i] > ranked[0])
                {
                    result.Add(1);
                }
                else if (player[i] < ranked[ranked.Count - 1])
                {
                    result.Add(indexes[indexes.Count - 1] + 1);
                }
                else
                {
                    int index = BinarySearch(ranked, player[i], indexes);
                    result.Add(index);
                }
            }


            Console.WriteLine(string.Join(" ", result));
        }

        private static int BinarySearch(List<int> ranked, int player, List<int> indexes)
        {
            int lo = 0;
            int hi = ranked.Count - 1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (ranked[mid] == player)
                {
                    return indexes[mid];
                }
                else if (ranked[mid] < player && ranked[mid - 1] > player)
                {
                    return indexes[mid];
                }
                else if (ranked[mid] > player && ranked[mid + 1] <= player)
                {
                    return indexes[mid + 1];
                }
                else if (ranked[mid] < player)
                {
                    hi = mid - 1;
                }
                else if (ranked[mid] > player)
                {
                    lo = mid + 1;
                }

            }
            return -1;
        }


        private static List<int> RankIndexes(List<int> ranked)
        {
            List<int> rankedIndexes = new List<int>();
            rankedIndexes.Add(1);

            for (int i = 1; i < ranked.Count; i++)
            {
                if (ranked[i] == ranked[i - 1])
                {
                    rankedIndexes.Add(rankedIndexes[i - 1]);
                }

                else
                {
                    rankedIndexes.Add(rankedIndexes[i - 1] + 1);
                }
            }
            return rankedIndexes;
        }
    }
}
