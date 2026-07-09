namespace Task_5_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Fixed Grades Array
            static void Task1()
            {
                Console.WriteLine("\nTask 1 - Grades");

                int[] studentGrades = new int[5];

                for (int gradeIndex = 0; gradeIndex < studentGrades.Length; gradeIndex++)
                {
                    Console.Write("Enter grade: ");
                    studentGrades[gradeIndex] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Grades:");

                foreach (int currentGrade in studentGrades)
                {
                    Console.WriteLine(currentGrade);
                }
            }
            ///////////////////////////////////////
            ///


            // Task 2 - Dynamic To-Do List
            static void Task2()
            {
                Console.WriteLine("\nTask 2 - To Do List");

                List<string> todoItems = new List<string>();

                for (int taskIndex = 0; taskIndex < 5; taskIndex++)
                {
                    Console.Write("Enter task: ");
                    string newTask = Console.ReadLine();

                    todoItems.Add(newTask);
                }

                Console.WriteLine("Your Tasks:");

                foreach (string todoItem in todoItems)
                {
                    Console.WriteLine("- " + todoItem);
                }
            }
            //////////////////////////////////////////
            ///



            // Task 3 - Browsing History Stack
            static void Task3()
            {
                Console.WriteLine("\nTask 3 - Browser History");

                Stack<string> browserHistory = new Stack<string>();

                for (int websiteIndex = 0; websiteIndex < 3; websiteIndex++)
                {
                    Console.Write("Enter website URL: ");
                    string websiteUrl = Console.ReadLine();

                    browserHistory.Push(websiteUrl);
                }

                string previousPage = browserHistory.Pop();

                Console.WriteLine("You went back from: " + previousPage);

                if (browserHistory.Count > 0)
                {
                    Console.WriteLine("Current page: " + browserHistory.Peek());
                }
            }
            ///////////////////////////////////////////////
            ///



            // Task 4 - Customer Service Queue
            static void Task4()
            {
                Console.WriteLine("\nTask 4 - Customer Queue");

                Queue<string> customerQueue = new Queue<string>();

                for (int customerIndex = 0; customerIndex < 3; customerIndex++)
                {
                    Console.Write("Enter customer name: ");
                    string customerName = Console.ReadLine();

                    customerQueue.Enqueue(customerName);
                }

                string servedCustomer = customerQueue.Dequeue();

                Console.WriteLine("Served customer: " + servedCustomer);
            }
            //////////////////////////////////////
            ///



        }
    }
}
