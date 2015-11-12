using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Shownumbers(a);
        }

        private static int Shownumbers(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Chisloto e chetno!");

            }
            if (a % 2 == 1)
            {
                Console.WriteLine("Chisloto e nechetno!");
            }

            return a;
        }
    }
}
