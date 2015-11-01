using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 16, 22, 67, 66, 33, 34, 2, 18, 56, 88 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }
                
            }
            for (int b = 0; b < arr.Length; b++)
            {
               
            }
            Console.WriteLine(sum);
        }
    }
}
