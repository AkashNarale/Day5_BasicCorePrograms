using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    internal class largestNumber
    {
        //program to find largest number among three numbers
        public static void UC10()
        {
            //taking input from user
            Console.WriteLine("Enter the 1st number :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd number :");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine("\n{0} is the largest number.", + x);
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("\n{0} is the largest number.", + y);
            }
            else
            {
                Console.WriteLine("\n{0} is the largest number.", + z);
            }
        }
    }
}
