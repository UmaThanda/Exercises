using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrConstantAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an alphabet to see if it is a vowel or a consonant");

                string a = Console.ReadLine();

            if(a == "a" ||a == "e" || a == "i" || a == "o" || a == "u")
            {
                Console.WriteLine("The alphabet is a Vowel");
            }
            else
            {
                Console.WriteLine("The alphabet is a Consonant");
            }
        }
    }
}
