namespace Homework06.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars =
         {
            new Car("Hyundai", 120),
            new Car("Mazda", 150),
            new Car("Ferrari", 200),
            new Car("Porsche", 180)
        };

            Driver[] drivers =
            {
            new Driver("Bob", 3),
            new Driver("Greg", 4),
            new Driver("Jill", 2),
            new Driver("Anne", 5)
        };

            Console.WriteLine("Choose a car no.1:");
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            int car1Index = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Choose a driver:");
            for (int i = 0; i < drivers.Length; i++)
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            int driver1Index = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Choose a car no.2:");
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            int car2Index = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Choose a driver:");
            for (int i = 0; i < drivers.Length; i++)
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            int driver2Index = int.Parse(Console.ReadLine()) - 1;

            cars[car1Index].Driver = drivers[driver1Index];
            cars[car2Index].Driver = drivers[driver2Index];

            RaceCars(cars[car1Index], cars[car2Index]);
        }

        static void RaceCars(Car car1, Car car2)
        {
            int speed1 = car1.CalculateSpeed();
            int speed2 = car2.CalculateSpeed();

            Console.WriteLine($"{car1.Model} with {car1.Driver.Name} speed: {speed1}");
            Console.WriteLine($"{car2.Model} with {car2.Driver.Name} speed: {speed2}");

            if (speed1 > speed2)
            {
                Console.WriteLine("Car no. 1 was faster.");
            }
            else if (speed1 < speed2)
            {
                Console.WriteLine("Car no. 2 was faster.");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

        }
    }
}
