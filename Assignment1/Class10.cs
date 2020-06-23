using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class10
    {
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 5; i <= n; i++)
            {
                sum = sum + (i * i * i);
            }
            Console.WriteLine(sum);
            Console.ReadLine();



        }
    }
}
