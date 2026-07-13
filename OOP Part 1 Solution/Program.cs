using System.Security.Cryptography.X509Certificates;

namespace OOP_Part_1_Solution
{

    // Add class Student with the following properties and methods:
    class student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        private string email { get; set; }
        int age { get; set; }

        //mothods 
        public void register(string Email)
        {
            email = Email;
        }
        private void sendEmail(string message)
        {
            Console.WriteLine($"Sending email to {email}: {message}");
        }



    }


    public class Program
    {


        static void Main(string[] args)
        {
            //Create an object with the class Student 
            //
            student B1 = new student();
            B1.Grade= 1163;
            B1.Name = "karim";
            B1.address= 120;
            
            
            //////////////////////////////////
            ///


        }



    }
}








