namespace Task_3_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                /////////////////////////////////////
                ///











            }
    }
}
