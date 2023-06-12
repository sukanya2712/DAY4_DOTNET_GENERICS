using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericproblems
{
    internal class problem44
    {
        public static void FindMinNumberr(int num1, int num2, int num3)
        {
            int min = num1;

            if (num2 < min)
            {
                min = num2;
            }

            if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine($"Largest number is :- {min}");
        }
    }
}
