using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericproblems
{
    public class Problem3<T> where T : IComparable<T>
    {
        public T element;
        public T[] arr;

        public Problem3(T[] arr,T element)
        {
            this.element = element;
            this.arr = arr;
        }

        public void generics(T[] aarr, T bele)
        {
            T[] temparray = new T[aarr.Length - 1];
            int flag = 0;
            for (int i = 0; i < aarr.Length; i++)
            {
                if (!aarr[i].Equals(bele))
                {
                    temparray[flag] = aarr[i];
                    flag++;
                }
            }
            Console.WriteLine("Modified array:");
            string result = string.Join(", ", temparray);
            Console.WriteLine(result);
        }

        public void testMinimum()
        {
            generics(arr,element);
        }
    }
}
