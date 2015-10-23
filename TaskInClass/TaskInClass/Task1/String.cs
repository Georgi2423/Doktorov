using System;

class String
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers: ");

        string a = Console.ReadLine();
        int x = int.Parse(a);
        string b = Console.ReadLine();

        Console.Write("The sum is: ");

        Console.WriteLine(a + b);

    }
}

