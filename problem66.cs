using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericproblems
{
    internal class problem66
    {
        public static void FindMinString(string str1, string str2, string str3)
        {
            string min = str1;

            if (String.Compare(str2, min) < 0)
            {
                min = str2;
            }

            if (String.Compare(str3, min) < 0)
            {
                min = str3;
            }

            Console.WriteLine($"Smallest number is :- {min}");
        }

    }
}
