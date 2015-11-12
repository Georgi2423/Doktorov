using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[4,4];

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int a = 0; a < arr.GetLength(1); a++)
                {
                    arr[i, a] = n--;

                }
            }
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    for (int k = 0; k < arr.GetLength(1); k++)
                    {
                        Console.Write("{0}\t" , arr[j,k]);
                    }
                Console.WriteLine();
                }
            
        }
    }
}
