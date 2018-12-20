using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 10");
            int randomNumber = Convert.ToInt16(Console.ReadLine());
           // Console.WriteLine(randomNumber);
             //Console.ReadKey();
            int count = 0;

            var Random = new Random();
            int systemRandom = Random.Next(1, 10);
            Console.WriteLine("System guess number is " + systemRandom);

            
            while (count <= 4)
            {
                if (!randomNumber.Equals(systemRandom))
                {
                    Console.WriteLine("Try again. Enter a number between 1 and 10");
                    randomNumber = Convert.ToInt16(Console.ReadLine());
                    count++;
                    if(count == 5)
                    {
                        Console.WriteLine("Better Luck Next Time...");
                    }
                    
                }
                
                else 
                {
                    Console.WriteLine("You Won");
                    break;
                }

            }
        }
    }
}
