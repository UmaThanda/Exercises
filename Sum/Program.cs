using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum of 2 numbers
            
            Console.WriteLine("Please enter the first number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            int result = (numberOne + numberTwo);
            Console.WriteLine("Sum is {0}", result);
        }
    }
}
