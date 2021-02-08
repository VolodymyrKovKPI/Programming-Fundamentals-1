using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Enter array length: ");
            var arrLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];

            Console.Write("The array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 100);
                Console.Write(arr[i] + "\t");
            }

            Console.WriteLine("\nEnter index to search from:");
            int from = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index to search to:");
            int to = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number of elements between indexes {from} and {to} is {CountRange(from, to, arr)}");

            Console.ReadKey();
        }

        public static int CountRange(int from, int to, int[] arr)
        {
            int sum = 0;

            for (int i = from; i < to; i++)
                sum++;

            return sum;
        }
    }
}