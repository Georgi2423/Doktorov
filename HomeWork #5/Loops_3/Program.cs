using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to enter: ");
            int numbersCount = 0;
            int.TryParse(Console.ReadLine(), out numbersCount);
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int n = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                Console.Write("Enter number: ");
                int.TryParse(Console.ReadLine(), out n);
               
                if (n > maxValue)
                {
                    maxValue = n;
                }
                if (n < minValue)
                {
                    minValue = n;
                }
            }
            Console.WriteLine("Min value is: {0}.", minValue);
            Console.WriteLine("Max value is: {0}.", maxValue);


        }
    }
}
