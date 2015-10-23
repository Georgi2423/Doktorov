using System;

    class Program
    {
    static void Main()
    {

        Console.WriteLine("Please enter two numbers:");
        string str = Console.ReadLine();
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();

        int x = int.Parse(str);
        int y = int.Parse(str1);
        int z = int.Parse(str2);

        Console.Write("You entered: ");
        Console.WriteLine((x+y)*z);
        

    }
    }
