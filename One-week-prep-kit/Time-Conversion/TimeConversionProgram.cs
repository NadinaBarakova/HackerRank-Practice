using System;
using System.Text;

namespace TimeConversion
{
    class TimeConversionProgram
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder(s);

            int hour = int.Parse(s.Substring(0, 2));

            if (s[s.Length - 2] == 'P')
            {
                if (hour == 12)
                {
                    sb.Remove(0, 2);
                    sb.Insert(0, hour);
                    sb.Remove(sb.Length - 2, 2);
                }
                else
                {
                    hour += 12;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                    if (hour == 0)
                    {
                        sb.Remove(0, 2);
                        sb.Insert(0, '0');
                        sb.Insert(1, '0');
                        sb.Remove(sb.Length - 2, 2);
                    }
                    else
                    {
                        sb.Remove(0, 2);
                        sb.Insert(0, hour);
                        sb.Remove(sb.Length - 2, 2);
                    }
                }
            }
            else
            {
                if (hour == 12)
                {
                    sb.Remove(0, 2);
                    sb.Insert(0, '0');
                    sb.Insert(1, '0');
                    sb.Remove(sb.Length - 2, 2);
                }
                else
                {
                    if (hour < 10)
                    {
                        sb.Remove(0, 2);
                        sb.Insert(0, '0');
                        sb.Insert(1, hour);
                        sb.Remove(sb.Length - 2, 2);
                    }
                    else
                    {
                        sb.Remove(0, 2);
                        sb.Insert(0, hour);
                        sb.Remove(sb.Length - 2, 2);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
