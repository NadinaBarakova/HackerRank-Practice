using System;
using System.Collections.Generic;
using System.Linq;

namespace AppleAndOrange
{
    class AppleAndOrangeProgram
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var secondLine = Console.ReadLine().Split();
            var thirdLine = Console.ReadLine().Split();
            List<int> apples = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> oranges = Console.ReadLine().Split().Select(int.Parse).ToList();

            int s = int.Parse(firstLine[0]);
            int t = int.Parse(firstLine[1]);
            int a = int.Parse(secondLine[0]);
            int b = int.Parse(secondLine[1]);

            apples = apples.Where(x => x + a >= s && x + a <= t).ToList();
            oranges = oranges.Where(x => x + b <= t && x + b >= s).ToList();


            Console.WriteLine(apples.Count);
            Console.WriteLine(oranges.Count);
        }
    }
}
