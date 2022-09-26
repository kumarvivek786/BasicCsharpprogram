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

            int a = 0, b = 0, c = 0;
            Console.WriteLine("Enter Three Numbers to Check Largest Of The Three");
            Console.Write("First: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("{0} is Largest", a);
            else if (b > a && b > c)
                Console.WriteLine("{0} is Largest", b);
            else if (c > a && c > b)
                Console.WriteLine("{0} is Largest", c);
            Console.ReadLine();
        }
    }
}
