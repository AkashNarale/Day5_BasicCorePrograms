using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assignment
{
    public class flipCoin
    {
        public static int noFlip;

        public static void Flip()
        {
            //taking input no of flip from user
            Console.WriteLine("Enter no of times flip the coin");
            noFlip = Convert.ToInt32(Console.ReadLine());
        }

        public static void HeadTail()
        {
            flipCoin.Flip();
            int tail = 0, head = 0;
            Random random = new Random();
            for (int i = 1; i <= noFlip; i++)
            {
                int ran = random.Next(0, 2);
                {
                    if (ran > 0.5)
                    {
                        tail++;
                    }
                    else
                    {
                        head++;
                    }
                }
            }

            Console.WriteLine("Number of time head occures :" + head);
            Console.WriteLine("Number of time tail occures :" + tail);
            double percentHead = (double)head / noFlip * 100;
            Console.WriteLine("Head percentage is :" + percentHead + " %");
            double percentTail = (double)tail / noFlip * 100;
            Console.WriteLine("Tail percentage is :" + percentTail + " %");
        }
    }
}
