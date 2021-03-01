using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Bank
    {
        string bankName;
        Account[] accounts = new Account[5];
        public string BankName { get => bankName; set => bankName = value; }

        public void AddAccount(Account account)
        {
           
            for (int i =0;i<5;i++)
            {
               
                
                if(accounts[i]==null)
                {
                    accounts[i] = account;
                    Console.WriteLine("Account addeed!");
                    break;
                }
              
                
            }
        }

        public void PrintAccountDetails()
        {
            for(int i = 0;i<5;i++)
            {
                if(accounts[i]!=null)
                {
                    accounts[i].ShowAccountInformation();
                }
                
            }
        }
       public void DeleteAccount(int accountNumber)
        {
            for (int i = 0; i < 5; i++)
            {
                if (accounts[i].AccountNumber==accountNumber)
                {
                    accounts[i] = null;
                    Console.WriteLine("Account deleted!");
                    break;
                }
                else
                {
                    Console.WriteLine("Account not found!!");
                }

            }
        }

      
    }
}
