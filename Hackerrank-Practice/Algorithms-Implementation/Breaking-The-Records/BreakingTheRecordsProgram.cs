using System;
using System.Collections.Generic;
using System.Linq;

namespace BreakingTheRecords
{
    class BreakingTheRecordsProgram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> scores = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> highestScore = new List<int>();
            List<int> lowestScore = new List<int>();
            highestScore.Add(scores[0]);
            lowestScore.Add(scores[0]);
            int highCounter = 0;
            int lowCounter = 0;
            if (scores.Count <= 1)
            {
                highCounter = 0;
                lowCounter = 0;
            }
            else
            {
                if (scores[0] > scores[1])
                {
                    highestScore.Add(scores[0]);
                    lowestScore.Add(scores[1]);
                    lowCounter++;
                }
                else if (scores[0] < scores[1])
                {
                    highestScore.Add(scores[1]);
                    lowestScore.Add(scores[0]);
                    highCounter++;
                }
                else
                {
                    highestScore.Add(scores[1]);
                    lowestScore.Add(scores[1]);
                }

                for (int i = 1; i < scores.Count - 1; i++)
                {
                    if (scores[i] < scores[i + 1])
                    {
                        if (lowestScore.Any(x => x <= scores[i]))
                        {
                            lowestScore.Add(lowestScore.Min());
                        }
                        else
                        {
                            lowestScore.Add(scores[i]);
                            lowCounter++;
                        }
                        if (highestScore.Any(x => x >= scores[i + 1]))
                        {
                            highestScore.Add(highestScore.Max());
                        }
                        else
                        {
                            highestScore.Add(scores[i + 1]);
                            highCounter++;
                        }
                    }
                    else if (scores[i] > scores[i + 1])
                    {
                        if (lowestScore.Any(x => x <= scores[i + 1]))
                        {
                            lowestScore.Add(lowestScore.Min());
                        }
                        else
                        {
                            lowestScore.Add(scores[i + 1]);
                            lowCounter++;
                        }
                        if (highestScore.Any(x => x >= scores[i]))
                        {
                            highestScore.Add(highestScore.Max());
                        }
                        else
                        {
                            highestScore.Add(scores[i]);
                            highCounter++;
                        }
                    }
                    else
                    {
                        lowestScore.Add(lowestScore.Min());
                        highestScore.Add(highestScore.Max());
                    }

                }
            }


            Console.WriteLine(string.Join(" ", highestScore));
            Console.WriteLine(string.Join(" ", lowestScore));
            Console.WriteLine(highCounter);
            Console.WriteLine(lowCounter);
        }
    }
}
