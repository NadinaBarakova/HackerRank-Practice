using System;
using System.Text;

namespace AppendAndDelete
{
    class AppendAndDeleteProgram
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            int index = 0;

            if (s.Length + t.Length <= k)
            {
                Console.WriteLine("Yes");
            }

            while (index < s.Length && index < t.Length && s[index] == t[index])
            {
                index++;
            }
            int req = t.Length - index + s.Length - index;
            k -= req;

            if (k >= 0 && k % 2 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
