﻿namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Fourth number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {average}");
        }
    }
}
