using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class3
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a number:");
            i = int.Parse(Console.ReadLine());
            if(i%2==0)
            {
                Console.WriteLine("Entered number is an even  number");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Entered number is an odd  number");
                Console.ReadLine();
            }
        }
    }
}
