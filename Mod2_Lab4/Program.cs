//This program demonstrate "while" Loop and "do while" Loop
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<6)
            {
                Console.WriteLine($"current value of i is {i}");
                i++;
             }

            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n < 5);
        }
    }
}
