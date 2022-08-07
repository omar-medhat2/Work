using System;


namespace ConsoleApp1
{
    internal class Program
    {
       
        public static System.Collections.Generic.List<BankAcc> myBank = new System.Collections.Generic.List<BankAcc>();
        static void Main(string[] args)
        {
            Console.WriteLine("We will now enter the customer's name. \nDoes the customer have an official title? Press 1 for yes and 2 for no.");
            string titleConfirmation = Console.ReadLine();
            string temptitle = "";
            bool titleexit = false;
            do
            {
                if (titleConfirmation == "1")
                {
                    Console.WriteLine("Please enter the specified title.");
                    temptitle = Console.ReadLine();
                    titleexit = true;
                }

                else if (titleConfirmation == "2")
                {
                    titleexit = true;
                }

                else
                    Console.WriteLine("Invalid input, please press 1 for yes and 2 for no.");
            }

            while (titleexit == false);

            Console.WriteLine("Please enter the customer's full name starting with the first name with the middle name as an initial followed by a dot and then the customer's last name.");
            string NameResult = Console.ReadLine();
            string[] NameSplit = NameResult.Split(' ');
            Name Customer_n = new Name(NameSplit[0], NameSplit[1], NameSplit[2], temptitle);

            Console.WriteLine("Please Enter Age");
            string a = Console.ReadLine();
            Console.WriteLine("Please Enter Customer ID");
            string d = Console.ReadLine();
            Console.WriteLine("Please Enter inital deposit");
            double dep = Convert.ToDouble(Console.ReadLine());
            if (dep < 1)
            {
                do
                {
                    Console.WriteLine("Invalid Deposit, please enter a valid deposit");
                    dep = Convert.ToDouble(Console.ReadLine());

                }

                while(dep < 1);
            }
            BankAcc User = new BankAcc(Customer_n, a, dep, Int64.Parse(d));
            myBank.Add(User);
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
                    if (w < 1 || w > User.Balance)
                        Console.WriteLine("Invalid Withdrawal");
                    else
                        User.withdraw(w);
                }

                else if (userInput == "3")
                {
                    Console.WriteLine(User.ToString());
                }

                else if (userInput == "4")
                {
                    exit = true;
                }

                else
                    Console.WriteLine("Invalid Input");


            }

            while (exit == false);
            
            
        }
    }
}
