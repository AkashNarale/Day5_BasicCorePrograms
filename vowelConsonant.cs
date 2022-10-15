using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    internal class vowelConsonant
    {
        //program to check alphabate is vowel or consonant
        public static void UC9()
        {
            //take input from user
            Console.WriteLine("Enter the alphabate :");
            char alpha = Convert.ToChar(Console.ReadLine());

            //to check input is a vowel or consonant
            if (alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u' || alpha == 'A' || alpha == 'E' || alpha == 'I' || alpha == 'O' || alpha == 'U')
            {
                Console.WriteLine(alpha + " is a Vowel");
            }
            else
            {
                Console.WriteLine(alpha + " is a Consonant");
            }
        }
    }
}
