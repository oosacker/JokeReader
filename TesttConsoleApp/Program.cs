using System;

namespace TesttConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jokes = readJokes();

            Console.WriteLine("Press any key to get a joke...\n");

            while (Console.ReadKey() != null)
            {
                Console.WriteLine(chooseJoke(jokes) + "\n");
            }
            
        }

        static string chooseJoke(string[] jokes)
        {
            Random ran = new Random();
            int random = ran.Next(0, jokes.Length);
            return jokes[random];
        }

        static string[] readJokes()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\apple\source\repos\TesttConsoleApp\TesttConsoleApp\jokes.txt");
            return lines;
        }
    }
}
