using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 5, 16, 20, 44, 56 };

            Arr(arr1);
            
        }

        private static void Arr(int[] arr1)
        {
            for (int i = arr1.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr1[i]);
            }
            
        }
    }
}
