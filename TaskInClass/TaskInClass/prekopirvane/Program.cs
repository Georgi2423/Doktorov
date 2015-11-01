using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prekopirvane
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int[] coppy = new int[a];
            int[] coppy1 = new int[a];
        
            for (int i = 0; i < coppy.Length; i++)
            {
                coppy[i] = int.Parse(Console.ReadLine());
           
              
            }
            for (int b = 0; b < coppy.Length; b++)
            {
                coppy1[b] = coppy[b];
                //Console.WriteLine(coppy1[b]);
            }
            foreach (var item in coppy1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
