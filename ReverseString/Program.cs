using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter  a word/sentence to reverse it");
            string input = Console.ReadLine();
           
           char[] reversedInput = input.ToCharArray();
           Array.Reverse(reversedInput);
           String output = new string(reversedInput);
           Console.WriteLine(output);
           
                
                    }
        }
    }

