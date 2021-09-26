using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<int> p = Console.ReadLine().Split().Select(int.Parse).ToList();

            Dictionary<int, int> seq = new Dictionary<int, int>();

            for (int i = 0; i < p.Count; i++)
            {
                seq.Add(p[i], i + 1);
            }
            List<int> result = new List<int>();
            for (int i = 1; i <= p.Count; i++)
            {
                result.Add(seq[seq[i]]);
            }
            Console.WriteLine(string.Join(" ", result));

            //var sequenceCount = int.Parse(Console.ReadLine());
            //var userInput = Console.ReadLine().Split(' ');

            //var sequenceDictionary = new Dictionary<int, int>();
            //for (int i = 0; i < sequenceCount; i++)
            //    sequenceDictionary.Add(int.Parse(userInput[i]), i + 1);

            //for (int x = 1; x <= sequenceCount; x++)
            //{
            //    var ppy = sequenceDictionary[sequenceDictionary[x]];
            //    Console.WriteLine(ppy);
            //}
        }
    }
}
