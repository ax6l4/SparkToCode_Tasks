using System.Security.Cryptography.X509Certificates;

namespace OOP_Part_1_Solution
{

    
    // Add class BankAccount with the following properties and methods:
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        private string email { get; set; }

        //methods
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void wirhdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
       public double CheckBalance()
        {
            return Balance;
        }
        private void printInformation()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
        private void sendEmail()
        {
            Console.WriteLine("Sending email to " + email);
        }


    }


    public class Program
    {


        static void Main(string[] args)
        {
            //Create an object with the class BankAccount
            //
            BankAccount B1 = new BankAccount();
            B1.AccountNumber= 1163;
            B1.HolderName = "karim";
            B1.Balance = 120;
            
            double result = B1.CheckBalance();
            //////////


        }



    }
}








