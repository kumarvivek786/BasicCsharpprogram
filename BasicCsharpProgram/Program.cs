using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();


            int n = 0, count1 = 0, count2 = 0;
            double HeadPercent = 0, TailPercent = 0;
            Console.WriteLine("Enter No. Of Coin Flip:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int r = random.Next(0, 2);
                if (r < 0.5)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }
            Console.WriteLine("Head Count:" + count1);
            Console.WriteLine("Tail Count:" + count2);
            HeadPercent = (count1 * 100) / n;
            TailPercent = (count2 * 100) / n;
            Console.WriteLine("Percentage of Heads: {0}%  and Percentage of Tails: {1}%", HeadPercent, TailPercent);
            Console.ReadLine();

        }
    }
}
