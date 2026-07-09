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


        }
    }
}
