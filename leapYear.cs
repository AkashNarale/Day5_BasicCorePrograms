using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    internal class leapYear
    {
        public static void UC2()
        {
            Console.WriteLine("Enter a year :");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year > 999 && year < 10000)
            {
                if (((year % 400) == 0) || ((year % 4) == 0) && ((year % 100) != 0))
                {
                    Console.WriteLine("{0} is a leap year", +year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year", +year);
                }
            }
            else
            {
                Console.WriteLine("Enter four digit year.");
            }
        }
    }
}
