using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class2

    {
        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int n2 = int.Parse(Console.ReadLine());
            while (n1 <= n2)
            {
                Console.WriteLine(n1);
                n1++;
            }
            Console.ReadKey();


        }
    }
}
