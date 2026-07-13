namespace OOP_Part_1_Solution
{
    // Add class BankAccount with the following properties and methods:
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

    }

        public class Program
    {


        static void Main(string[] args)
        {
            //Create an object with the class BankAccount
            //
            BankAccount account = new BankAccount();
            account.AccountNumber = 123456;
            account.HolderName = "John Doe";
            account.Balance = 1000.0;
            // Display the account information
            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Holder Name: " + account.HolderName);
            Console.WriteLine("Balance: $" + account.Balance);

        }



    }
}








