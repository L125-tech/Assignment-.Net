using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class4
    {
        static void Main()
        {
            int n, even = 0, odd = 0;
            Console.WriteLine("Enter any number:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {


                    even = even + 1;
                }


                else
                {
                    odd = odd + 1;
                }
            }
                Console.WriteLine("number of odd digit is " + odd);
                Console.WriteLine("number of even digit is " + even);
                Console.ReadKey();


            }

        }
    }
