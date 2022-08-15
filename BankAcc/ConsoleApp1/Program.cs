using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace ConsoleApp1
{
    internal class Program
    {
       
        public static System.Collections.Generic.List<BankAcc> myBank = new System.Collections.Generic.List<BankAcc>();
        static void Main(string[] args)
        {
            string userInput = "0";
            BankAcc User = null;
            bool exit = false;
            do {
                Console.WriteLine("Welcome to Bank Application\nPlease choose a service; Press 1 to enter a new customer, Press 2 to deposit, Press 3 to Withdraw, Press 4 to display all information, and Press 5 if you would like to quit");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.WriteLine("We will now enter the customer's name. \nDoes the customer have an official title? Press 1 for yes and 2 for no.");
                    string titleConfirmation = Console.ReadLine();
                    short titleinput = 0;
                    bool titleexit = false;
                    do
                    {
                        if (titleConfirmation == "1")
                        {
                            Console.WriteLine("Please choose from available titles \n1: Eng.\n2: Dr.\n3: Mr.\n4: Ms.\n5: Mrs.");
                            titleinput = Convert.ToInt16(Console.ReadLine());
                            titleexit = true;
                        }

                        else if (titleConfirmation == "2")
                        {
                            titleinput = 0;
                            titleexit = true;
                        }

                        else { 
                            Console.WriteLine("Invalid input, please press 1 for yes and 2 for no.");
                            titleConfirmation = Console.ReadLine();
                        }
                    }

                    while (titleexit == false);
                    bool NameExit = false;
                    string NameResult = null;
                    do {
                        Console.WriteLine("Please enter the customer's full name starting with the first name with the middle name as an initial then the customer's last name.");
                        NameResult = Console.ReadLine();
                        
                        try
                        {

                            Regex regex1 = new Regex("^[A-Za-z ]+$");

                            if (!regex1.IsMatch(NameResult))
                                throw new InvalidNameException(NameResult);
                            else
                                NameExit = true;
                        }
                        catch (InvalidNameException ex)
                        {
                            Console.WriteLine(ex.Message);
                            NameExit = false;
                        }
                    }
                    while (NameExit == false);

                    string[] NameSplit = NameResult.Split(' ');
                    Name Customer_n = new Name(NameSplit[0], NameSplit[1], NameSplit[2], titleinput);
                    string a;
                    bool Ageexit = false;
                    do
                    {
                        Console.WriteLine("Please Enter Age");
                        a = Console.ReadLine();
                        try
                        {
                            Regex regexAge = new Regex(@"^\d+$");
                            if (!regexAge.IsMatch(a))
                                throw new InvalidAgeException();
                            else
                                Ageexit = true;
                        }

                        catch (InvalidAgeException ea)
                        {
                            Console.WriteLine(ea.Message);
                        }
                    }
                    while (Ageexit == false);
                    
                    bool IDexit = false;
                    string d;
                    do {
                        Console.WriteLine("Please Enter Customer ID");
                        d = Console.ReadLine();
                        try {
                            Regex regexID = new Regex("^[0-9]{14}$");
                            if (!regexID.IsMatch(d))
                                throw new InvalidIDException();
                            else
                                IDexit = true;
                        }

                        catch(InvalidIDException es)
                        {
                            Console.WriteLine(es.Message);
                        }
                    }
                    while (IDexit == false);
                    bool genderExit = false;
                    string g;
                    short gender_C = 0;
                    do { 
                        
                        Console.WriteLine("Please specify customer gender, press 1 for Male and 2 for Female");
                        g = Console.ReadLine();

                        if (g == "1") { 
                            gender_C = 1;
                            genderExit = true;
                        }
                        else if (g == "2") { 
                            gender_C = 2;
                            genderExit = true;
                        }
                        else {
                            Console.WriteLine("Invalid Gender, please press 1 for Male and 2 for Female");
                            genderExit = false;
                        }

                    }
                    while(genderExit == false);
                    bool DepositExit = false;
                    string depValid;
                    do {
                        Console.WriteLine("Please Enter inital deposit");
                        depValid = Console.ReadLine();
                        try {
                            Regex regex = new Regex(@"^\d+$");
                            if (!regex.IsMatch(depValid))
                                throw new InvalidDepositException();
                            else
                                DepositExit = true;
                        }

                        catch(InvalidDepositException es)
                        {
                            Console.WriteLine(es.Message);
                        }
                    }
                    while (DepositExit == false);
                    double dep = Convert.ToDouble(depValid);
                    if (dep < 1)
                    {
                        do
                        {
                            Console.WriteLine("Invalid Deposit, please enter a valid deposit");
                            dep = Convert.ToDouble(Console.ReadLine());

                        }

                        while (dep < 1);
                    }

                     User = new BankAcc(Customer_n, a, dep, Int64.Parse(d),GetGender(gender_C));
                    
                    myBank.Add(User);
                }
               else if (userInput == "2")
                {
                    Console.WriteLine("Please enter deposit amount");
                    int w = int.Parse(Console.ReadLine());
                    if (w < 1)
                        Console.WriteLine("Invalid Deposit");
                    else
                        User.deposit(w);
                }

                else if (userInput == "3")
                {
                    Console.WriteLine("Please enter withdrawal amount");
                    int w = int.Parse(Console.ReadLine());
                    if (w < 1 || w > User.Balance)
                        Console.WriteLine("Invalid Withdrawal");
                    else
                        User.withdraw(w);
                }

                else if (userInput == "4")
                {
                    Console.WriteLine(User.ToString());
                }

                else if (userInput == "5")
                {
                    exit = true;
                }

                else
                    Console.WriteLine("Invalid Input");


            }

            while (exit == false);
            
            
        }
        public static Gender GetGender(short genderinput)
        {
            switch (genderinput)
            {
                case 1: return Gender.Male;
                case 2: return Gender.Female;
                default: return Gender.Unknown;
            }
        }
    }
}
