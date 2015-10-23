using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete promenliva");
            string choise = Console.ReadLine();
    
            switch (choise)
            {
                case "int":    
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);
                    break;
                case "double":
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);
                    break;
                case "string":
                    string abv = Console.ReadLine();
                    Console.WriteLine(abv + "*");
                    break;
                default:
                    Console.WriteLine("Greshka pri vuvejdane");
                    break;
            }
        }
    }
}
