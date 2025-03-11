using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskFromClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DateTime currentDateTime = DateTime.Now;

            //Print the date that is 3 days from now
            DateTime addedThreeDays = currentDateTime.AddDays(3);
            Console.WriteLine(addedThreeDays);

            //Print the date that is one month from now
            DateTime addedMonths = currentDateTime.AddMonths(1);
            Console.WriteLine(addedMonths);

            // Print the date that is one month and 3 days from now
            DateTime addedMonthsAndDays = currentDateTime.AddMonths(1).AddDays(3);
            Console.WriteLine(addedMonthsAndDays);


            // Print 1 year and 2 months ago from today
            DateTime removedYearAndMonths = currentDateTime.AddYears(-1).AddMonths(-2);
            Console.WriteLine(removedYearAndMonths);

            // Print only the current month of today
            int currentMonth = currentDateTime.Month;
            Console.WriteLine(currentMonth);

            //Print only the current year of today�
            int currentYear = currentDateTime.Year;
            Console.WriteLine(currentYear);
            

        }
    }
}
