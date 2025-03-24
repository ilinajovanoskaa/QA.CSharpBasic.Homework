

namespace Class07.Exercises.App
{
  public class Employee
    {
        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - Salary: {GetSalary()}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
