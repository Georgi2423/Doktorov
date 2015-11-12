using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n*n];
            int[,] arr2 = new int[n,n];
            int counter = 0;
            int sum = 0;
            Random rand = new Random();


            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(0, 9);
                sum += arr1[i];
                Console.WriteLine("{0}\t", arr1[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i,j] = arr1[counter++];
         
                }
                

            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                   Console.Write("{0}\t", arr2[j, i]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The sum is: {0}", sum);


        }
    }
}
