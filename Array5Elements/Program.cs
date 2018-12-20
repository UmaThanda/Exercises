using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array5Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] number = new int[5]{1, 2, 3, 4, 5 };
            for(int i = 0; i <=number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

        }
    }
}
