using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you choise from the playing cards");
            //int choise = int.Parse(Console.ReadLine());
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "2":
                    Console.WriteLine("Валидна карта");
                    break;
                case "3":
                    Console.WriteLine("Валидна карта");
                    break;
                case "4":
                    Console.WriteLine("Валидна карта");
                    break;
                case "5":
                    Console.WriteLine("Валидна карта");
                    break;
                case "6":
                    Console.WriteLine("Валидна карта");
                    break;
                case "7":
                    Console.WriteLine("Валидна карта");
                    break;
                case "8":
                    Console.WriteLine("Валидна карта");
                    break;
                case "9":
                    Console.WriteLine("Валидна карта");
                    break;
                case "10":
                    Console.WriteLine("Валидна карта");
                    break;
                case "J":
                    Console.WriteLine("Валидна карта");
                    break;
                case "Q":
                    Console.WriteLine("Валидна карта");
                    break;
                case "K":
                    Console.WriteLine("Валидна карта");
                    break;
                case "A":
                    Console.WriteLine("Валидна карта");
                    break;

                default:
                    Console.WriteLine("Невалидна карта");
                    break;
            }
           
            
        }
    }
}
