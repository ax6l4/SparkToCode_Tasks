namespace Task_1_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Personal Info Card
            //
            string name = "Sara";
            int age = 21;
            double height = 1.65;
            bool student = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Student: " + student);
            //////////////////////////////////////////
            ///


            //2- Rectangle Calculator
            //
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            /////////////////////////////////////////
            ///


            //3- Even or Odd Checker
            //
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
                /////////////////////////////////
            }
    }
}
