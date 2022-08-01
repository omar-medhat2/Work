using System;


namespace ConsoleApp1
{
    internal class BankAcc
    {
        string Customer_Name;
        string Customer_Age;
        int balance;
        string id;

        public BankAcc(string Customer_Name, string Customer_Age, int balance, string id)
        {
            this.Customer_Name = Customer_Name;
            this.Customer_Age = Customer_Age;
            this.balance = balance;
            this.id = id;
        }
        public void deposit(int depo) 
        {
            balance += depo;
            Console.WriteLine("Deposit Successful");
        }
        public void withdraw(int withdrawal)
        {
            balance -= withdrawal;
            Console.WriteLine("Withdrawal Successful");
        }
        public void display()
        {
            Console.WriteLine("Name: " + Customer_Name);
            Console.WriteLine("Age: " + Customer_Age);
            Console.WriteLine("ID Number: " + id);
            Console.WriteLine("Account Balance: " + balance);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Customer Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter Age");
            string a = Console.ReadLine();
            Console.WriteLine("Please Enter Customer ID");
            string d = Console.ReadLine();
            Console.WriteLine("Please Enter inital deposit");
            int dep = int.Parse(Console.ReadLine());
            BankAcc User = new BankAcc(name, a, dep, d);
            string userInput = "0";
            bool exit = false;
            do {
                Console.WriteLine("Please choose a service; Press 1 to deposit, Press 2 to Withdraw, Press 3 to display all information, and Press 4 if you would like to quit");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.WriteLine("Please enter deposit amount");
                    int w = int.Parse(Console.ReadLine());
                    if (w < 1)
                        Console.WriteLine("Invalid Deposit");
                    else
                        User.deposit(w);
                }

                else if (userInput == "2")
                {
                    Console.WriteLine("Please enter withdrawal amount");
                    int w = int.Parse(Console.ReadLine());
                    if (w < 1)
                        Console.WriteLine("Invalid WIthdrawal");
                    else
                        User.withdraw(w);
                }

                else if (userInput == "3")
                {
                    User.display();
                }

                else if (userInput == "4")
                {
                    exit = true;
                }

                else
                    Console.WriteLine("Invalid Input");


            }

            while (exit == false);
            Console.WriteLine("Thank you for using this service");
        }
    }
}
