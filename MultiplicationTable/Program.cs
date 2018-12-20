using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for its multiplication table");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", n * 1);
            Console.WriteLine("{0}", n * 2);
            Console.WriteLine("{0}", n * 3);
            Console.WriteLine("{0}", n * 4);
            Console.WriteLine("{0}", n * 5);
            Console.WriteLine("{0}", n * 6);
            Console.WriteLine("{0}", n * 7);
            Console.WriteLine("{0}", n * 8);
            Console.WriteLine("{0}", n * 9);
            Console.WriteLine("{0}", n * 10);
           // Console.ReadLine();
        }
    }
}
