

namespace Class07.Exercises.App
{
    public class SalesPerson : Employee
    {
       

        public SalesPerson(string firstName, string lastName) 
            : base(firstName, lastName, Role.Sales, 500)
        {
        }

        private double SuccessSaleRevenue;

        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue = revenue;
        }

        public override double GetSalary()
        {
            double bonus = 0;

            if (SuccessSaleRevenue <= 2000)
            {
                bonus = 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                bonus = 1000;
            }
            else
            {
                bonus = 1500;
            }

            return Salary + bonus;
        }
    }
}
