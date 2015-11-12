using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            int[,] arr = new int[,] {
                {1,3,55},
                {12,8,1},
                {31,1,11},
        };

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }


            for (int w = 0; w < arr.GetLength(0); w++)
            {
                sum += arr[w, w];
            }
            Console.WriteLine("Sumata po glavniq diagonal e: {0}",sum);

        }

    }
}
