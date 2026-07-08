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



        }
    }
}
