using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product();

            Console.WriteLine( "Here is the product details" );

            prod.Offer();
            prod.title();

        }
    }
}
