using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    internal class oddEven
    {
        //program to check number is even or odd
        public static void UC8()
        {
            //taking input from user
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The given number is even number.");
            }
            else
            {
                Console.WriteLine("The given number is odd number.");
            }
        }
    }
}
