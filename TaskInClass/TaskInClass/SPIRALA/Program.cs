using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MatrixSpiral
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        FillMatrix(matrix, n);

        PrintMatrix(matrix, n);
    }

    private static void FillMatrix(int[,] matrix, int n)
    {
        int count = n * n;
        int positionX = n / 2;
        int positionY = n % 2 == 0 ? ((n / 2) - 1) : (n / 2);


        int direction = 0;
        int stepsCount = 1;
        int stepPosition = 0;
        int stepChange = 0;

        for (int i = 0; i < count; i++)
        {
            matrix[positionY, positionX] = i;
            if (stepPosition < stepsCount)
            {
                stepPosition++;
            }
            else
            {
                stepPosition = 1;

                if (stepChange == 1)
                {
                    stepsCount++;
                }
                stepChange = (stepChange + 1) % 2;
                direction = (direction + 1) % 4;
            }

            switch (direction)
            {
                case 0:
                    positionY++;
                    break;
                case 1:
                    positionX--;
                    break;
                case 2:
                    positionY--;
                    break;
                case 3:
                    positionX++;
                    break;
            }
        }
    }

    private static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}