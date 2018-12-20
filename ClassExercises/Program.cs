using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string myName;
            //Console.WriteLine("Hello World");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What is your favorite things?");
            string yourFavoriteThings = Console.ReadLine();
            Console.WriteLine("Your Name is " + yourName +  " and your FavoriteThing(s) is/are "  + yourFavoriteThings);
            Console.WriteLine("Your Name is {0} {1}" + yourName + "your favorite things are " + yourFavoriteThings);
            Console.WriteLine($"Your name is {yourName} {yourFavoriteThings}");
            Console.WriteLine(string.Format{0},{1} + yourName + yourFavoriteThings);
            Console.ReadKey();
        }
    }
}
