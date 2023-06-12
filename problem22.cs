using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace genericproblems
{
    internal class problem22
    {

        public void generics<T>(T[] aarr, T bele)
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
            string result = string.Join(", ", temparray.Take(flag));
            Console.WriteLine(result);
        }
    }
}
