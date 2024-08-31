namespace Assign_03
{
    /// <summary>
    /// Displays the Employee information
    /// </summary>
    internal class EmployeeDriver
    {
        static void Main(string[] args)
        {
            //initializes employee1 object
            Employee employee1 = new Employee();

            //sets values for employee1
            employee1.Name = "Garry";
            employee1.Id = 1;
            employee1.Salary = 90000;

            Console.WriteLine($"Original Employee {employee1.Id} information\n{employee1}");
            Console.WriteLine(employee1);

            //updates employee1 name
            employee1.Name = "Larry";

            Console.WriteLine($"\nUpdated Employee {employee1.Id} information");
            Console.WriteLine(employee1);

            //creates parameterized employee2 object
            Employee employee2 = new Employee("John", 2, 70000);

            Console.WriteLine($"\nOriginal Employee {employee2.Id} information");
            Console.WriteLine(employee2);

            //updates employee2 salary
            employee2.Salary = 100000;

            Console.WriteLine($"\nUpdated Employee {employee2.Id} information");
            Console.WriteLine(employee2);
        }
    }
}
