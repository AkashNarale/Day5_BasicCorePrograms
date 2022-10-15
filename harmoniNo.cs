using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    internal class harmoniNo
    {
        public static void UC4()
        {
            double sum = 0.0;
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                for (double i = 1; i <= num; i++)
                {
                    sum = sum + 1 / i;
                }
                Console.WriteLine("The Nth Harmonic Series is :" + sum);
            }
            else
            {
                Console.WriteLine("Please enter number greater than 0.");
            }
        }
    }
}
