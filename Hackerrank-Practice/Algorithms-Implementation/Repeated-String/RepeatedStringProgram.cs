using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = long.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int otherCounter = 0;
                for (int i = 0; i < n%s.Length; i++)
                {
                    if (s[i]=='a')
                    {
                        otherCounter++;
                    }
                }

                long result = n / s.Length * counter + otherCounter;
                Console.WriteLine(result);
            }
        }
    }
}
