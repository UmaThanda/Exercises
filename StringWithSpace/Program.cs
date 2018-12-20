using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWithSpace
{
    class Program
    {
        static void Main(string[] args)
        {//separate individual characters string with space

            Console.WriteLine("Please enter a word to split by space");
            string text = Console.ReadLine();
            char[] t = text.ToCharArray();
            for (int i = 0; i <= t.Length; i++)
            {
                Console.Write((t[i]));
                Console.Write(" ");
            }


        }
    }
}
