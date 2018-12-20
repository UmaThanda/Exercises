using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("You get to win based on color you choose");
                Console.WriteLine("Which color you prefer--- green or red");
                string color = Console.ReadLine();
                if(color == "green")
                {
                    Console.WriteLine("You Won!!!");
                }
                else
                {
                    Console.WriteLine("You are done playing. Better Luck Next Time.");
                }
            }
            else
            {
                Console.WriteLine("You have only one chance to play");
                Console.WriteLine("You want a star or lime");
                string choice = Console.ReadLine();
                if(choice == "star")
                {
                    Console.WriteLine("You Won!!!");
                }
                else
                {
                    Console.WriteLine("Time over...Good Bye!!!");
                }
            }

            Console.WriteLine("Thank you for playing!");

        }
    }
}
