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



            // Task 2 - Power & Root Explorer
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Square: " + Math.Pow(number, 2));
            Console.WriteLine("Square Root: " + Math.Sqrt(number));



            // Task 3 - Name Formatter
            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.WriteLine("Lowercase: " + name.ToLower());
            Console.WriteLine("Characters: " + name.Length);



            // Task 4 - Subscription End Date
            Console.Write("Enter free trial days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            DateTime endDate = DateTime.Today.AddDays(days);

            Console.WriteLine("Trial Ends: " + endDate.ToString("yyyy-MM-dd"));



            // Task 5 - Grade Rounding System
            Console.Write("Enter exam score: ");
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



            // Task 6 - Password Strength Checker
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (password.Length >= 8 && !password.ToLower().Contains("password"))
            {
                Console.WriteLine("Strong");
            }
            else
            {
                Console.WriteLine("Weak");
            }



            // Task 7 - Clean Name Comparator
            Console.Write("Enter first name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter second name: ");
            string name2 = Console.ReadLine();

            if (name1.Trim().ToUpper() == name2.Trim().ToUpper())
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }



            // Task 8 - Membership Expiry Checker
            try
            {
                Console.Write("Enter membership start date (yyyy-MM-dd): ");
                string inputDate = Console.ReadLine();

                DateTime startDate = DateTime.Parse(inputDate);

                Console.Write("Enter membership days: ");
                int membershipDays = Convert.ToInt32(Console.ReadLine());

                DateTime expiryDate = startDate.AddDays(membershipDays);

                Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Membership: Active");
                }
                else
                {
                    Console.WriteLine("Membership: Expired");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("All Tasks Completed!");

            Console.ReadLine();








        }
    }
}
