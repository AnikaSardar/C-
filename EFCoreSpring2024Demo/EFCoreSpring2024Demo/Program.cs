using EFCoreSpring2024Demo.DBClasses;

namespace EFCoreSpring2024Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CIS340_01_SARDAR_AContext()) //only closes it but doesn't handle exceptions
            {
                var customers = db.Customers.ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.CustomerId);
                }
                var cust = db.Customers.Where (cust => cust.CustomerId == 2).Single();
                Console.WriteLine($"{cust.CustomerId} and {cust.FirstName} and {cust.LastName}");

                var newCustomer = new Customer { Phone= "7153334569", FirstName= "Mary", LastName="Ty", Email="maryTy@yahoo.com"  };
                db.Add(newCustomer);
                db.SaveChanges();//needed

            }

        }
    }
}