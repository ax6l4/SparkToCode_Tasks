namespace Task_3_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            Console.WriteLine("Positive Difference: " + difference);
            /////////////////////////////////
            ///


            // Task 2 - Power & Root Explorer
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            double square = Math.Pow(number, 2);
            double root = Math.Sqrt(number);

            Console.WriteLine("Square: " + square);
            Console.WriteLine("Square Root: " + root);
            /////////////////////////////////
            ///

        }
    }
}
