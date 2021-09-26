using System;
using System.Collections.Generic;
using System.Linq;

namespace CutTheSticks
{
    class CutTheSticksProgram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int length = arr.Count;
            List<int> result = new List<int>();

            while (arr.Count > 0)
            {
                result.Add(arr.Count);
                int cut = arr.Min();
                arr = arr.Select(x => x - cut).ToList();
                arr.RemoveAll(x => x == 0);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
