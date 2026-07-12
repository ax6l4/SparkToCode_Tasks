using System;
using System.Collections.Generic;

namespace BankingSystemApp
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();


        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Search Customer");
                Console.WriteLine("8. Exit");

                Console.Write("Choose an option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }


                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;

                    case 2:
                        DepositMoney();
                        break;

                    case 3:
                        WithdrawMoney();
                        break;

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank.");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }



        // 1- Add Account
        static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();


            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Account number already exists.");
                return;
            }


            Console.Write("Enter initial deposit amount: ");
            double deposit = double.Parse(Console.ReadLine());


            if (deposit < 0)
            {
                Console.WriteLine("Deposit cannot be negative.");
                return;
            }


            customerNames.Add(name);
            accountNumbers.Add(accountNumber);
            balances.Add(deposit);


            Console.WriteLine("\nAccount created successfully!");
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + deposit);
        }



        // 2- Deposit Money
        static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();


            int index = accountNumbers.IndexOf(accountNumber);


            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }


            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());


            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive.");
                return;
            }


            balances[index] += amount;


            Console.WriteLine("\nDeposit successful!");
            Console.WriteLine("New Balance: " + balances[index]);
        }



        // 3- Withdraw Money
        static void WithdrawMoney()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();


            int index = accountNumbers.IndexOf(accountNumber);


            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }


            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());


            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive.");
                return;
            }


            if (amount > balances[index])
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }


            balances[index] -= amount;


            Console.WriteLine("\nWithdrawal successful!");
            Console.WriteLine("New Balance: " + balances[index]);
        }
    }
}


