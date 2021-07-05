using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with length and height for matrix: ");
            string[] mn = Console.ReadLine().Split(' ');
            int m = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);

            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Enter the values for the line " + (i + 1));
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nEnter the number in the matrix: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == number)
                    {
                        Console.WriteLine($"\nPosition: {i + 1}, {j + 1}");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {matrix[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Top: {matrix[i - 1, j]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Bottom: {matrix[i + 1, j]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Right: {matrix[i, j + 1]}");
                        }
                    }
                }
            }
        }
    }
}