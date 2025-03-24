

namespace Class07.Exercises.App
{
    public class Manager : Employee
    {
       

        public Manager(string firstName, string lastName, double salary) 
            : base(firstName, lastName, Role.Manager, salary)
        {
        }

        private double Bonus;

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}

