using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework07.App
{
    public class CEO : Employee

    {
        public CEO(string firstName, string lastName, double salary, int shares, Employee[] employees)
            : base(firstName, lastName, Role.Manager, salary)
        {
            Shares = shares;
            Employees = employees;
        }



        private double SharesPrice;
        public int Shares { get; set; }
        public Employee[] Employees { get; set; }

        
        public void AddSharesPrice(double price)
        {
            SharesPrice = price;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var emp in Employees)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }
    }
}
