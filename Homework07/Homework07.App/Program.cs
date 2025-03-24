namespace Homework07.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Bob", "Bobert", 2000);
            Manager manager2 = new Manager("Rick", "Rickert", 2500);

            Contractor contractor1 = new Contractor("Mona", "Monalisa", 160, 15, manager1);
            Contractor contractor2 = new Contractor("Igor", "Igorsky", 150, 20, manager2);
            

            Employee[] company = { contractor1, contractor2, manager1, manager2 };

            CEO ceo = new CEO("Ron", "Ronsky", 1500, 100, company);
            ceo.AddSharesPrice(14);

            ceo.PrintInfo();
            ceo.PrintEmployees();
            Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");
        }
    }
}
