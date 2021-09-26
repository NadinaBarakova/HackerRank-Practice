using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> h = Console.ReadLine().Split().Select(int.Parse).ToList();
            string word = Console.ReadLine();
            List<int> heights = new List<int>();
            List<char> alphabet = new List<char>();

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add(i);
            }


            for (int i = 0; i < word.Length; i++)
            {
                if (alphabet.Contains(word[i]))
                {
                    int height = alphabet.IndexOf(word[i]);
                    heights.Add(height);
                }
            }
            List<int> res = new List<int>();
            for (int i = 0; i < heights.Count; i++)
            {
                var r = h[heights[i]];
                res.Add(r);
            }

            int maxElement = res.Max();

            int result = maxElement * word.Length;

            Console.WriteLine(result);
        }
    }
}
