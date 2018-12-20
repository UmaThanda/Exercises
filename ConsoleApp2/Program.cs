using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Write a program to print the output of multiplication
            // of three numbers which will be entered by the user.
            
            Console.WriteLine("Please enter three numbers seperated by comma");
            string input = Console.ReadLine();
            
            int [] inputArray = new int[5];
            int result = 0;
            for (int i = 0; i <= 5; i++)
            {
               
                // split method splits string and returns an array
                inputArray[i] = int.Parse(input.Split(' ')[i]);

                
                result *= inputArray[i];
            }
            Console.WriteLine(result);
            
           
        }

       
    }
}
