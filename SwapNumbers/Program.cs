namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Swapping the numbers
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine($"First Number: {num1}");
            Console.WriteLine($"Second Number: {num2}");
        }
    }
}
