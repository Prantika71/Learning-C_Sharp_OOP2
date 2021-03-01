using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        Address address;
        

        public string AccountName { get => accountName; set => accountName = value; }
        public double Balance { get => balance; set => balance = value; }
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        
        public Account(string accountName,double balance,Address address)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
            Random r = new Random();
            this.accountNumber = r.Next(999999);
        }
        public void Withdraw(double amount )
        {
          if(amount>this.Balance)
            {
                Console.WriteLine("You don't have sufficient balance");
            }
          else if (amount == 0 || amount <= 0)
            {
                Console.WriteLine("You have entered invalid input");
            }
          else
            {
                this.balance = this.balance - amount;
                Console.WriteLine("Withdraw success \n");
                Console.WriteLine("New balance:"+this.Balance);
            }
        }

        public void Deposite(double amount)
        {
            this.balance = this.balance + amount;
            Console.WriteLine("Deposite success \n");
            Console.WriteLine("New balance:" + this.Balance);
        }

        public void Transfer(Account receiver,double amount)
        {
            receiver.Balance = receiver.Balance + amount;
            this.Balance = this.Balance - amount;
            Console.WriteLine("Tansfer successfull of amount"+amount);
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\nAccount name: "+this.AccountName);
            Console.WriteLine("\nAccount balace: "+this.Balance);
            Console.WriteLine("\nAccount number: "+this.AccountNumber+"\n");
            address.getAddress();
            
        }

        
    }
}
