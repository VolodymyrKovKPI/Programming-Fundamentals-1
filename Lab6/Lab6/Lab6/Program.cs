using System;
using System.IO;
using System.Linq;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            int[] inputArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int cursor = 0;


            Console.WriteLine("Enter array length: ");
            var arrLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];

            Console.Write("The array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (cursor >= inputArray.Length)
                    cursor = 0;

                arr[i] = inputArray[cursor++];
                Console.Write(arr[i] + "\t");
            }

            Console.WriteLine("\nEnter index to search from:");
            int from = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index to search to:");
            int to = int.Parse(Console.ReadLine());


            using (StreamWriter sw = File.CreateText("array.txt"))
            {
                sw.Write($"Your array is:\t");

                for (int i = 0; i < arr.Length; i++)
                {
                    sw.Write(arr[i] + "\t");
                }
                
                sw.Write(sw.NewLine);
                sw.Write($"You selected the following range:\t");

                for (int i = from; i < to; i++)
                {
                    sw.Write(arr[i] + "\t");
                }

                sw.Write(sw.NewLine);
                sw.WriteLine($"The number of elements between indexes {from} and {to} is {CountRange(from, to, arr)}");
            }

            Console.WriteLine("Operation successful");
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
