using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simetrichen_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] type = new int[length];

            for (int i = 0; i < type.Length; i++)
            {
                type[i] = int.Parse(Console.ReadLine());

            }
            bool symetric = true;
            for (int i = 0; i < type.Length / 2; i++)
            {
                if (type[i]! = type[length - 1 - i])
                {
                symetric = false;
                }
            }
            foreach (var item in type)
            {
                Console.WriteLine(item);
            }
        }
    }
}
