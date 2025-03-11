namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Ana", "Mila", "Ilina", "Martina", "Olgica" };

            Console.Write("Enter student group: (there are 1 and 2) ");
            int group = int.Parse(Console.ReadLine());

            if (group == 1)
            {
                Console.WriteLine("The Students in G1 are:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if (group == 2)
            {
                Console.WriteLine("The Students in G2 are:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Invalid group number. Please enter 1 or 2.");
            }
        }
    }
}
