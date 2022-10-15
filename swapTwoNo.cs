using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    internal class swapTwoNo
    {
        //program to swap the two numbers
        public static void UC7()
        {
            int z;
            //taking input from user
            Console.WriteLine("Enter first number :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBefore swapping numbers are :");
            Console.WriteLine("1st no =" + x);
            Console.WriteLine("2nd no =" + y);

            z = x;
            x = y;
            y = z;

            Console.WriteLine("\nAfter swapping numbers are :");
            Console.WriteLine("1st no =" + x);
            Console.WriteLine("2nd no =" + y);
        }
    }
}
