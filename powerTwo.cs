using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    internal class powerTwo
    {
        public static void UC3()
        {
            Console.WriteLine("Enter the power of 2 till you want to display.");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 1 && num < 32)
            {
                for (int i = 1; i <= num; i++)
                {
                    //using Math.Pow method() to calculate power
                    //Pow method(2,count) means 2 to power count
                    double pow = Math.Pow(2, i);
                    Console.WriteLine("Power of 2 of {0} is {1}", +i, +pow);
                }
            }
            else
            {
                Console.WriteLine("Enter number between 1 to 31");
            }
        }
    }
}
