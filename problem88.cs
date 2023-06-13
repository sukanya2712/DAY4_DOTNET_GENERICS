using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericproblems
{
    public class Problem88<T> where T : IComparable<T>
    {
        public T num1, num2, num3;

        public Problem88(T num1, T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        public static void P7(T num1, T num2, T num3)
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

        public void testMinimum()
        {
            P7(this.num1, this.num2, this.num3);
        }
    }
}
