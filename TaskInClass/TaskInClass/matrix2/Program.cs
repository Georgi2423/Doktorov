using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 16;
            int[,] arr = new int[4, 4];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int a = 0; a < arr.GetLength(0); a++)
            {
                for (int b = 0; b < arr.GetLength(1); b++)
                {
                    if (n % 2 == 1)
                    {
                        n *= 2;
                    }

                    Console.Write("{0}\t", arr[a, b]);
                }
                Console.WriteLine();

            }


        }
    }
}
