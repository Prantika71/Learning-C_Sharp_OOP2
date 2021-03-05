using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bank bank = new Bank();
            bank.BankName="DBBL";
            Address ad1 = new Address("1/D", "498", "DHAKA", "BANGADESH");
            
            
            Account a1 = new Account("Sneha",90000,ad1);
            bank.AddAccount(a1);
          
            Address ad2 = new Address("1/B", "48", "DHAKA", "BANGADESH");
            Account a2 = new Account("Durjoy", 50000, ad2);

            Address ad3 = new Address("1/A", "45", "JESSORE", "NEWYORK");
            Account a3 = new Account("Anik",10000,ad3);
            
            bank.AddAccount(a2);
            


            bank.AddAccount(a3);
            

            Address ad4 = new Address("4", "149", "CUMILLA", "NOAKHALI");
            Account a4 = new Account("PRANTIKA", 6000, ad4);
            bank.AddAccount(a4);
            Console.WriteLine("After adding accounts: \n");
            bank.PrintAccountDetails();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("After deposite to account 3: \n");

            a3.Deposite(6000);
            a3.ShowAccountInformation();
            Console.WriteLine("---------------------------------------------");
            a2.Transfer(a3, 500);
            Console.WriteLine("After transfer balance:");
            a2.ShowAccountInformation();
            a3.ShowAccountInformation();
            Console.WriteLine("---------------------------------------------");
            a1.Withdraw(500);
            Console.WriteLine("After withdraw method:");
           
            a1.ShowAccountInformation();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("After deleting account 4: \n");
            bank.DeleteAccount(a4.AccountNumber);
            bank.PrintAccountDetails();











        }
    }
}
