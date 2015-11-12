using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] {
                {1,12,55},
                {22,8,13},
                {31,14,20},
        };
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                    if (arr[i,j] % 2 == 0)
                    {
                        
                        Console.WriteLine(arr[i,j]);
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
