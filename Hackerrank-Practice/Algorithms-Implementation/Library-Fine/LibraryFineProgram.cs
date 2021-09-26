using System;

namespace LibraryFine
{
    class LibraryFineProgram
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split();
            var input2 = Console.ReadLine().Split();

            int d1 = int.Parse(input1[0]);
            int m1 = int.Parse(input1[1]);
            int y1 = int.Parse(input1[2]);
            int d2 = int.Parse(input2[0]);
            int m2 = int.Parse(input2[1]);
            int y2 = int.Parse(input2[2]);

            int d = (d1 - d2) * 15;
            int m = (m1 - m2) * 500;
            int y = (y1 - y2) * 10000;
            if (m > 0 && d != 0 && y == 0)
            {
                d = 0;
            }
            if (y > 0 && m != 0 && d != 0)
            {
                d = 0;
                m = 0;
            }
            int result = d + m + y;

            if (result < 0)
            {
                result = 0;
            }

            Console.WriteLine(result);
        }
    }
}
