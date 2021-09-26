using System;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cumulative = 2;
            int shared = 5;
            int liked = shared / 2;


            for (int i = 1; i < n; i++)
            {
                shared = liked * 3;
                liked = shared / 2;
                
                cumulative += liked;

            }
            Console.WriteLine(cumulative);
        }
    }
}
