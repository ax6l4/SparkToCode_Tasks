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


            //Task 3 - Name Formatter
            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.WriteLine("Lowercase: " + name.ToLower());
            Console.WriteLine("Number of characters: " + name.Length);
            ///////////////////////////////////
            ///


            // Task 4 - Subscription End Date
            Console.Write("Enter free trial days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddDays(days);

            Console.WriteLine("Trial Ends: " + endDate.ToString("yyyy-MM-dd"));
            ///////////////////////////////////
            ///


            // Task 5 - Grade Rounding System
            Console.WriteLine("Task 5 - Grade Rounding System");

            Console.Write("Enter your score: ");
            double score = Convert.ToDouble(Console.ReadLine());

            double roundedScore = Math.Round(score);

            Console.WriteLine("Rounded Score: " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }


            Console.WriteLine("----------------------------");
            Console.WriteLine("All Tasks Completed!");

            Console.ReadLine();
            ////////////////////////////////
            ///


            // Task 6 - Password Strength Checker
            Console.WriteLine("----------------------------");
            Console.WriteLine("Task 6 - Password Strength Checker");

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool longEnough = password.Length >= 8;
            bool containsPassword = password.ToLower().Contains("password");

            if (longEnough && !containsPassword)
            {
                Console.WriteLine("Password Strength: Strong");
            }
            else
            {
                Console.WriteLine("Password Strength: Weak");

                if (!longEnough)
                {
                    Console.WriteLine("Reason: Password must be at least 8 characters.");
                }

                if (containsPassword)
                {
                    Console.WriteLine("Reason: Password cannot contain the word password.");
                }
            }

            Console.ReadLine();
            ////////////////////////////////
            ///



            // Task 7 - Clean Name Comparator

            Console.Write("Enter first name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter second name: ");
            string name2 = Console.ReadLine();

            name1 = name1.Trim().ToUpper();
            name2 = name2.Trim().ToUpper();

            if (name1 == name2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }

            Console.ReadLine();
            ///////////////////////////////////
            ///






        }
    }
}
