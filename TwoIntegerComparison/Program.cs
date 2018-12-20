using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegerComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a == b)
            {
                Console.WriteLine("Two numbers are equal");
            }
            else
            {
                Console.WriteLine("Two numbers are not equal");
            }
        }
    }
}
