using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualizeTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int result = 0;

            var groups = arr.GroupBy(x => x);
            int maxGroupCount = 0;
            foreach (var group in groups)
            {
                if (group.Count() > maxGroupCount)
                {
                    maxGroupCount = group.Count();
                }

            }

            result = arr.Count() - maxGroupCount;

            Console.WriteLine(result);
        }
    }
}
