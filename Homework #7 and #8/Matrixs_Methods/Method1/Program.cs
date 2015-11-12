using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxNumber(a, b));
            MaxNumber(a, b);
        }

        private static int MaxNumber(int a, int b)
        {
            if (a > b)
            {
                return a;

            }

            else return b;
        }
    }
}
