using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    public class Account
    {
        string name;
        string dob;
        string address;
        double balance;
        int transactions;
        string type;

        public Account (string name, string dob, string address,string type)
            {
            this.name = name;
            this.address = address;
            this.dob = dob;
            this.balance = 0;
            this.transactions = 0;
            this.type = type;
            }
        public void Withdraw(double amount)
        {
            if(this.type=="sav")
            {
                if (amount > this.Balance )
                {
                    
                    Console.WriteLine("You don't have sufficient balance");
                }
                else if (amount <= 0)
                {
                    Console.WriteLine("You have entered invalid input");
                }
                else
                {
                    if (this.balance - amount > 0)
                    {
                        this.balance = this.balance - amount;
                        Console.WriteLine("Withdraw success \n");
                        
                    }
                    else 
                    {
                        Console.WriteLine("Saving account's balance cannot be empty");

                    }
                       
                }
            }

              else if(this.type=="check")
                    {
                if (amount > this.Balance)
                {

                    Console.WriteLine("You don't have sufficient balance");
                }
                else if (amount <= 0)
                {
                    Console.WriteLine("You have entered invalid input");
                }
                else
                {
                
                        this.balance = this.balance - amount;
                        Console.WriteLine("Withdraw success \n");

                    

                }
            }
            
        }

        public void Deposite(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("You have entered invalid input");
            }
            else
            {
                this.balance = this.balance + amount;
                Console.WriteLine("Deposite success \n");
                Console.WriteLine("New balance:" + this.Balance);
            }

        }

        public void Transfer(Account receiver, double amount)
        {
            if(receiver != null)
            {
                if (this.balance < amount)
                {
                    Console.WriteLine("TransFer not possible!!!Not Enough money");
                }
                else if (amount <= 0)
                {
                    Console.WriteLine("You have entered invalid input");
                }
                else
                {
                    receiver.Balance = receiver.Balance + amount;
                    this.Balance = this.Balance - amount;
                    Console.WriteLine("Tansfer successfull of amount" + amount);
                }
            }
            else
            {
                Console.WriteLine("No user found with this serial no! Input a valid serial.");
            }

        }

        public void show()
        {
            Console.WriteLine("\nBalance: "+this.balance);
            Console.WriteLine("\nTransaction number:"+this.transactions);
        }

        public string Name { get => name; set => name = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value; }
        public double Balance { get => balance; set => balance = value; }
        public int Transactions { get => transactions; set => transactions = value; }
    }
}
