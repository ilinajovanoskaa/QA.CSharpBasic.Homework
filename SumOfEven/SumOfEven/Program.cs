namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numbers = new int[6];
            int sum = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter integer no.{i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 6; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine($"The result is: {sum}");
        }
    }
}
