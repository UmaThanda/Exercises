using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class LowerCase
    {
       static void Main(string[] args)
        {// convert any given string in all lowercase

            Console.WriteLine("please enter a word in caps to get the lower case word");
            string input = Console.ReadLine();
            Console.WriteLine(input.ToLower());
            Console.WriteLine("Thank You :)");
           
          
        }
    }
}
