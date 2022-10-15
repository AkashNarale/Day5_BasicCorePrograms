using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    internal class quotient
    {
        public static void UC6()
        {
            int quo = 0, rim = 0;
            //taking input divident and divisor from user
            Console.WriteLine("Enter dividend = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor = ");
            int y = Convert.ToInt32(Console.ReadLine());

            quo = x / y;
            rim = x % y;
            Console.WriteLine("{0} and {1} are the quotient and remainder of {2}", +quo, +rim, +x);

        }
    }
}
