using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int i = int.Parse(input[0]);
            int j = int.Parse(input[1]);
            int k = int.Parse(input[2]);
            int counter = 0;

            for (int iter = i; iter <= j; iter++)
            {
                string iterStr = Convert.ToString(iter);
                StringBuilder sb = new StringBuilder();
                for (int iterSec = iterStr.Length - 1; iterSec >= 0; iterSec--)
                {
                    sb.Append(iterStr[iterSec]);
                }

                int reversedIter = int.Parse(sb.ToString());

                if (Math.Abs(iter - reversedIter) % k == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
