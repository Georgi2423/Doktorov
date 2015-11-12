using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Showsums(a, b, c));

            Showsums(a, b, c);
        }

        static int Showsums(int a, int b, int c)
        {
            int sum = a * b * c;
            return sum;

        }
    }
}
