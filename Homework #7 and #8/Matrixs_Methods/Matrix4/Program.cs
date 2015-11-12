using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[5, 6];

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
                    Console.Write("{0}\t", arr[j, k]);
                }
                Console.WriteLine();
            }
        }
    }
}
