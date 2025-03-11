namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Enter your birthday (yyyy-MM-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - birthDate.Year;

            
            if (DateTime.Now < birthDate.AddYears(age))
            {
                age--;
            }

            Console.WriteLine($"Your age is: {age}");


        }
    }
}
