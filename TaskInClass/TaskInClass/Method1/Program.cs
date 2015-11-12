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
            int a = 15;
            int b = 20;
            int sum = consolesum(a, b);

            Console.WriteLine(sum);
            consolesum(a, b);
        }

        private static int consolesum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}
