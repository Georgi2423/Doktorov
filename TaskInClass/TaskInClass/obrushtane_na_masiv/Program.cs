using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrushtane_na_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] type = new int[length];

            for (int i = 0 ; i < type.Length; i++)
            {
                type[i] = int.Parse(Console.ReadLine());
                
            }
            for (int r = 0; r < type.Length/2; r++)
            {
                int c;
                c = type[r];
                type[r] = type[length - r - 1];
                type[length - r - 1] = c;
                
                


            }
            foreach (var item in type)
            {
                Console.WriteLine(item);
            }
        }
    }
}
