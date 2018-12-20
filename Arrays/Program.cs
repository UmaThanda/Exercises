using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5] { "Alphine", "Amanda", "Arunachal", "Ahobil", "Simachal" };
            Console.WriteLine("The names are: ");
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);

            Console.WriteLine( "*****************");
            Console.WriteLine("The numbers are  ");
            int[] numbers = new int[3] { 1, 2, 3 };
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}