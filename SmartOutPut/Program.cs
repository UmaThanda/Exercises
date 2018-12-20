using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >1 && age <= 15)
            {
                Console.WriteLine("You are an awesome kid");
            }
            else if (age >16 && age <= 40)
            {
                Console.WriteLine("You are such a wonderful person");
            }
            else if (age > 41 && age <= 70)
            {
                Console.WriteLine("You are a successful person");
            }
            else if (age > 70)
            {
                Console.WriteLine("We need your wisdom and blessings");
            }
        }
    }
}
