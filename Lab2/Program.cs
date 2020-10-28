using System;

namespace Lab2
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Title = "Awesome Console Application | Варіант 10";
            Console.WriteLine("Welcome to the Awesome Console App!\nPress any key to continue...");
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            #region Демонстрація Console.Read
            //           var read = Console.Read();
            //           Console.WriteLine(read);    
            #endregion

            while (true)
            {
                Console.Write("Enter 'r' to reset Console color...\n" +
                              "Enter 'q' to exit the application\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "q":
                        Environment.Exit(0);
                        break;
                    case "r":
                        Console.ResetColor();
                        Console.WriteLine("The color was successfully reset.");
                        break;
                    default:
                        Console.WriteLine("Bad command. Try again.");
                        Console.WriteLine();
                        continue;
                }
            }
        }
	}
}
