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
                ///


                //4- Voting Eligibility
                //
                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Do you have valid ID? (yes/no): ");
                string answer = Console.ReadLine();

                bool hasID;

                if (answer == "yes")
                {
                    hasID = true;
                }
                else
                {
                    hasID = false;
                }


                if (age >= 18 && hasID)
                {
                    Console.WriteLine("Eligible to vote");
                }
                else
                {
                    Console.WriteLine("Not eligible to vote");
                    /////////////////////////////////
                    ///


                    //5- Grade Letter Lookup
                    //
                    Console.Write("Enter grade: ");
                    char grade = Convert.ToChar(Console.ReadLine());

                    switch (grade)
                    {
                        case 'A':
                            Console.WriteLine("Excellent");
                            break;

                        case 'B':
                            Console.WriteLine("Very Good");
                            break;

                        case 'C':
                            Console.WriteLine("Good");
                            break;

                        case 'D':
                            Console.WriteLine("Pass");
                            break;

                        case 'F':
                            Console.WriteLine("Fail");
                            break;

                        default:
                            Console.WriteLine("Invalid grade");
                            break;
                            ////////////////////////////////////
                            ///


                            //6- Temperature Converter
                            //
                            Console.Write("Enter temperature in Celsius: ");
                            double celsius = Convert.ToDouble(Console.ReadLine());

                            double fahrenheit = (celsius * 9 / 5) + 32;

                            string weather;

                            if (celsius < 10)
                            {
                                weather = "Cold";
                            }
                            else if (celsius <= 30)
                            {
                                weather = "Mild";
                            }
                            else
                            {
                                weather = "Hot";
                            }

                            Console.WriteLine("Fahrenheit: " + fahrenheit);
                            Console.WriteLine("Weather: " + weather);
                            //////////////////////////////////////////
                    }
                }
}
