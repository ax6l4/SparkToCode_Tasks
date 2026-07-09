namespace Task_4_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        // Task 1 - Personalized Welcome Function
        static void PrintWelcome(string userName)
        {
            Console.WriteLine("Welcome " + userName);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            string userNameInput = Console.ReadLine();

            PrintWelcome(userNameInput);

            Console.ReadKey();

                /////////////////////////////////////////
                ///


                // Task 2 - Square Number Function
                static int Square(int numberValue)
                {
                    return numberValue * numberValue;
                }
                ////////////////////////////////
                ///



                // Task 3 - Celsius to Fahrenheit Function
                static double CelsiusToFahrenheit(double celsiusValue)
                {
                    return (celsiusValue * 9 / 5) + 32;
                }
                ///////////////////////////////////
                ///


                // Task 4 - Fixed Menu Display Function
                static void DisplayMenu()
                {
                    Console.WriteLine("1) Start");
                    Console.WriteLine("2) Help");
                    Console.WriteLine("3) Exit");
                }
                //////////////////////////////////
                ///


                // Task 5 - Even or Odd Function
                static bool IsEven(int checkNumber)
                {
                    return checkNumber % 2 == 0;
                }
                /////////////////////////////////
                ///









            }
        }
}
