using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] arr = new int[,] {
                {1,3,55},
                {12,8,44},
                {31,62,11},
        };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[j,i]);
                }
                Console.WriteLine();
            }
        }
    }
}
