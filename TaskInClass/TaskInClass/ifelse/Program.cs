using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Vuvedete chislo:");
        int x = int.Parse(Console.ReadLine());
        if (x >= 1 && x <= 5)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Chisloto e chetno");
            }
            else
            {
                Console.WriteLine("Chisloto e nechetno");
            }
        }
        else if (x >= 6 && x <= 15)
        {
            if (x % 3 == 0)

            {
                Console.WriteLine("Chisloto se deli na 3 bez ostatuk");
            }
            else
            {
                Console.WriteLine("Chisloto se deli na 3 s ostatuk");
            }
        }
        else
        {
            if (x > 0)
            {
                Console.WriteLine("Chisloto e polojitelno");
            }
            else if (x < 0)
            {
                Console.WriteLine("Chisloto e otricatelno");
            }
            else
            {
                Console.WriteLine("Chisloto e 0");
            }
        }


    }
}

