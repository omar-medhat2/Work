using System;

namespace ConsoleApp1
{
    internal class BankAcc : IBanktransactions
    {
        private Name fullName;
        private string age;
        private double balance;
        private long id;


        public BankAcc(Name Customer_Name, string Customer_Age, double balance,long id)
      {
          this.fullName = Customer_Name;
          this.Age = Customer_Age;
          this.Balance = balance;
          this.ID = id;
      }

        public Name FullName
        {
            set { this.fullName = value; }
            get { return this.fullName; }
        }

        

        public string Age
        {
            set { this.age = value; }
            get
            {
                return this.age;
            }
        }
        public double Balance
        {
            set
            {
                this.balance = value;
            }

            get { 
                return this.balance; 
                }
        }

        public long ID
        {
            set 
            { 
                if (Math.Floor(Math.Log10(value) + 1) != 14)
                {
                    throw new Exception("ID cannot be less than 14 digits");
                }
                if (value < 0)
                {
                    throw new Exception("ID cannot be negative");
                }
                this.id = value; 
            }
            get { return this.id; }
        }

        
        /*public void deposit(int depo)
        {

            balance += depo;
            Console.WriteLine("Deposit Successful");
        }
        public void withdraw(int withdrawal)
        {
            balance -= withdrawal;
            Console.WriteLine("Withdrawal Successful");
        }*/
        public void deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposit Successful");
        }

        public void withdraw(int amount)
        {
            balance -= amount;
            Console.WriteLine("Withdrawal Successful");
        }

        public override string ToString()
        {
            return $"Name: {fullName.ToString()} \nAge: {age}\nID: {id}\nBalance: {balance}";

        }

        
    }
}
