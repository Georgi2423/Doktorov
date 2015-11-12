using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
