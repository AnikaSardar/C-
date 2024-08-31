namespace BMICalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This program calculate BMI based on user's inputs

            Console.WriteLine("Welcome to the body mass index (BMI) calculator");
            Console.Write("Enter your weight in pouds: ");
            Double.TryParse(Console.ReadLine(), out double weight);

            Console.Write("Enter your height in inches: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double calculateBMI = (weight * 703) / (height * height);
            Console.WriteLine($"Your BMI is : {calculateBMI:f2}");

            Console.WriteLine("\nBMI VALUES");
            Console.WriteLine("Underweight: \tless than 18.5\nNormal: \tbetween 18.5 and 24.9\nOverweight:  \tbetween 25 and 29.9\nObese:   \t30 or greater");
        }
    }
}