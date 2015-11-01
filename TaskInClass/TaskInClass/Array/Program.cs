using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete edno chislo: ");
            int a = int.Parse(Console.ReadLine());
            
            int[] b = new int[a];
            for (int i = 0; i < b.Length; i++)
            {

                b[i] = i + 10;

            }
            for (int t = 0; t < b.Length; t++)
            {
                Console.WriteLine(b[t]);
            }
          
           
        }
    }
}
