using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    internal class factors
    {
        //find prime factors of a number
        public static void UC5()
        {
            //taking input from user
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            //local Variable
            int isPrime;
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = 1;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine("Prime Factor is :" + i);
                    }
                }
            }
        }
    }
}
