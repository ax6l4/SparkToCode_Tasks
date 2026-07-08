namespace Task_2_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Countdown Timer
            Console.Write("Enter starting number: ");
            int start = int.Parse(Console.ReadLine());

            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Liftoff!");
            ////////////////////////////////
            ///



            // Task 2 - Sum of Numbers 1 to N
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum = " + sum);
            ///////////////////////////////
            ///


            // Task 3 - Multiplication Table

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + n + " = " + (number * n));
            }
            /////////////////////////////
            ///





            // Task 4 - Password Retry

            string correctPassword = "Spark2026";
                string password = "";

                while (password != correctPassword)
                {
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();

                    if (password != correctPassword)
                    {
                        Console.WriteLine("Incorrect password, try again");
                    }
                }

                Console.WriteLine("Access Granted");
                /////////////////////////////
                ///


                // Task 5 - Number Guessing Game

                int secretNumber = 42;
                int guess;
                int attempts = 0;

                do
                {
                    Console.Write("Guess the number: ");
                    guess = int.Parse(Console.ReadLine());

                    attempts++;

                    if (guess > secretNumber)
                    {
                        Console.WriteLine("Too high");
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low");
                    }
                    else
                    {
                        Console.WriteLine("Correct!");
                    }

                } while (guess != secretNumber);

                Console.WriteLine("Attempts: " + attempts);
                ////////////////////////////
                ///


                // Task 6 - Safe Division Calculator

                try
                {
                    Console.Write("Enter first number: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double result = num1 / num2;

                    Console.WriteLine("Result = " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred");
                }
                ////////////////////////////
                ///



                // Task 7 - Repeating Menu

                int choice = 0;

                while (choice != 3)
                {
                    Console.WriteLine("1) Say Hello");
                    Console.WriteLine("2) Show Greeting");
                    Console.WriteLine("3) Exit");
                    Console.Write("Choose: ");

                    try
                    {
                        choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Hello!");
                                break;

                            case 2:
                                Console.WriteLine("Good morning!");
                                break;

                            case 3:
                                Console.WriteLine("Exit");
                                break;

                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number");
                    }
                }
            ///////////////////////////
            ///



            // Task 8 - Sum of Even Numbers Only

            Console.Write("Enter N: ");
            int limit = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = 1; i <= limit; i++)
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine("Sum of even numbers = " + total);
            ////////////////////////////////////
            ///








        }
    }
}
