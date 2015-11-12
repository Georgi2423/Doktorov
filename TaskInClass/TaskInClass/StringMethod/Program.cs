using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "абвгдежзийклмн";

            Str(str1);
        }

        private static void Str(string str1)
        {
            for (int i = str1.Length-1; i >= 0 ; i--)
            {
                Console.WriteLine(str1[i]);
            }
        }
    }
}
