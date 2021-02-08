using System;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 8];

            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                }
            }

            DisplayMatrix(matrix);

            FindMinSum(matrix);

            Console.ReadKey();
        }

        public static void FindMinSum(int[,] arr)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++) //стовпці
            {
                var minItem = int.MaxValue;

                for (int i = 0; i < arr.GetLength(0); i++) //рядки
                {

                    if (arr[i, j] < minItem)
                    {
                        minItem = arr[i, j];
                    }
                }

                Console.WriteLine($"Мінімальний елемент стовпця {j+1}: {minItem}");

                sum += minItem;
            }

            Console.WriteLine($"\nСума мінімальних елементів стовпців: {sum}");
        }

        public static void DisplayMatrix(int[,] arr)
        {
            Console.WriteLine("Матриця:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}