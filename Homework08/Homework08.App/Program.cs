using System.Collections;

namespace Homework08.App
{
    internal class Program
    {
        static void PrintAllNums(IEnumerable collection, string name)
        {
            Console.WriteLine($"Collection {name} items: ");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Queue<int> numQueue = new Queue<int>();
            string userInput = "y";

            while (userInput == "y")
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                numQueue.Enqueue(number);

                Console.Write("Do you want to enter another number? y/n: ");
                userInput = Console.ReadLine().ToLower();
            }

            PrintAllNums(numQueue, "Number in Queue");

        }
    }
}
