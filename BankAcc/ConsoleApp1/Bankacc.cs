using System;

namespace ConsoleApp1
{
    internal class BankAcc : IBanktransactions
    {
        private Name fullName;
        private string age;
        private double balance;
        private long id;
        private Gender gender;


        public BankAcc(Name Customer_Name, string Customer_Age, double balance,long id, Gender gender)
      {
          this.FullName = Customer_Name;
          this.Age = Customer_Age;
          this.Balance = balance;
          this.ID = id;
          this.Gender = gender;
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
                this.id = value; 
            }
            get { return this.id; }
        }

        public Gender Gender
        {
            set
            {
                this.gender = value;
            }

            get { return this.gender; }

        }


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
            return $"Name: {fullName.ToString()} \nAge: {age}\nGender: {gender}\nID: {id}\nBalance: {balance}";

        }

        
    }
}
