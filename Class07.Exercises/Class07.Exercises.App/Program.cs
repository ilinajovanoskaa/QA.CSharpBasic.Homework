namespace Class07.Exercises.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesPerson salesPerson = new SalesPerson("John", "Doe");
            salesPerson.AddSuccessRevenue(3000);
            salesPerson.PrintInfo();

            Manager manager = new Manager("Alice", "Smith", 4000);
            manager.AddBonus(1000);
            manager.PrintInfo();
        }
    }
}
