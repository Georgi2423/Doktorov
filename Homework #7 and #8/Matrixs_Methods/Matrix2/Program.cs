using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                   
                }

            }
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    Console.Write("{0}\t", arr[k, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
