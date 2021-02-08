using System;
using System.IO;
using System.Linq;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;

            string input = File.ReadAllText("input.txt");
            int[] arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            

            int[,] matrix = new int[size, size];
            int cursor = arr.Length - 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = arr[cursor--];
                }
            }

            DisplayMatrix(matrix);

            FindMinSum(matrix);

            Console.WriteLine("Success!");
            Console.ReadKey();
        }

        public static void FindMinSum(int[,] arr)
        {
            using (StreamWriter sw = File.AppendText("array.txt"))
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

                    sw.WriteLine($"\nМінімальний елемент стовпця {j + 1}: {minItem}");

                    sum += minItem;
                }

                sw.WriteLine($"\nСума мінімальних елементів стовпців: {sum}");
            }
        }

        public static void DisplayMatrix(int[,] arr)
        {
            using (StreamWriter sw = File.CreateText("array.txt"))
            {
                sw.WriteLine("Матриця:");

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        sw.Write(arr[i, j] + "\t");
                    }

                    sw.Write(sw.NewLine);
                }
            }
        }
    }
}
