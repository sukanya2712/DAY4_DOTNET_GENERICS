using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericproblems
{
    internal class problem77
    {
        public static void P7<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            T min = num1;

            if (num2.CompareTo(min) < 0)
            {
                min = num2;
            }

            if (num3.CompareTo(min) < 0)
            {
                min = num3;
            }

            Console.WriteLine($"Smallest :- {min}");
        }
    }
}
