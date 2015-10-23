using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you score from 1 to 9:");
            int a = int.Parse(Console.ReadLine());

            if (a >= 1 && a <=3)
            {
                Console.WriteLine(a*5);
            }
            else if (a >= 4 && a <=6)
            {
                Console.Write("Your score is: ");
                Console.WriteLine(a*10);
            }
            else if (a >= 7 && a <=9)
            {
                Console.Write("Your score is: ");
                Console.WriteLine(a*50);
            }
        }
    }
}
