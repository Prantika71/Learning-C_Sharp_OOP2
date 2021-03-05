using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    public class Bank
    {
        int ab = 50;
        string input;
        Account[] a = new Account[10];
        public void Start()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\nCommand : task \n");
            Console.WriteLine("open : Open an account\n");
            Console.WriteLine("account : Perform tranaction on an acount\n");
            Console.WriteLine("quit : Quit application\n");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Enter a command: \n");
            
           input = Console.ReadLine().ToString();
            this.Menu();
           


        }
        public void Menu()
        {
            switch(this.input)
            {
                case "open":
                                Console.WriteLine("____________________________________");
                                Console.WriteLine("\n Command : task \n");
                                Console.WriteLine("savings : Open a savings account \n");
                                Console.WriteLine("checking : Open a checking account \n");
                                Console.WriteLine("quit : Quit application\n");
                                Console.WriteLine("Enter a command: \n");
                                input = Console.ReadLine().ToString();
                                this.Menu();
                                break;
                                


                case "account":
                    if (ab != 50)
                    {
                        Console.WriteLine("____________________________________");
                        Console.WriteLine("\n Command : task \n");
                        Console.WriteLine("deposit : Make a deposit \n");
                        Console.WriteLine("withdraw : Make a withdrawal \n");
                        Console.WriteLine("transfer :  Make a transfer \n");
                        Console.WriteLine("show : show the number transactions and balance \n");
                        Console.WriteLine("quit : Exit the application \n");
                        Console.WriteLine("Enter a command: \n");
                        input = Console.ReadLine().ToString();
                        this.Menu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Create an account first!");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("\nCommand : task \n");
                        Console.WriteLine("open : Open an account\n");
                        Console.WriteLine("account : Perform tranaction on an acount\n");
                        Console.WriteLine("quit : Quit application\n");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Enter a command: \n");

                        input = Console.ReadLine().ToString();
                        this.Menu();

                        break;
                    }


                    

                case "quit":

                    if (ab != 50 && ab !=12)
                                {
                                ab = 12;
                                this.Menu();
                                break;

                                }
                                else if(ab==12)
                                {
                        Console.WriteLine("\nCommand : task \n");
                        Console.WriteLine("open : Open an account\n");
                        Console.WriteLine("account : Perform tranaction on an acount\n");
                        Console.WriteLine("quit : Quit application\n");
                        Console.WriteLine("Enter a command: \n");

                        input = Console.ReadLine().ToString();
                        this.Menu();
                        break;

                    }
                              else 
                    {
                                 Console.Clear();

                        break;

                                }

                case "savings":
                                Console.WriteLine("____________________________________");
                                Console.WriteLine("Enter name: \n");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter birth of date in this format dd/mm/yyyy: \n");
                                string dob= Console.ReadLine();
                                Console.WriteLine("Enter address: \n");
                                string address = Console.ReadLine();
                                this.Create(name, dob, address, "sav");
                                input = "account";
                                this.Menu();
                                break;

                case "checking":
                                Console.WriteLine("____________________________________");
                                Console.WriteLine("Enter name: \n");
                                string name1 = Console.ReadLine();
                                Console.WriteLine("Enter birth of date in this format dd/mm/yyyy: \n");
                                string dob1 = Console.ReadLine();
                                Console.WriteLine("Enter address: \n");
                                string address1 = Console.ReadLine();
                                this.Create(name1, dob1, address1, "check");
                                input = "account";
                                this.Menu();
                    break;

                case "deposit":

                    Console.WriteLine("____________________________________");
                    Console.WriteLine("Enter amount:");
                    Double am=Convert.ToDouble(Console.ReadLine());

                    a[ab].Deposite(am);
                    input = "account";
                    a[ab].Transactions++;
                    this.Menu();

                    break;

                case "transfer":

                    Console.WriteLine("____________________________________");
                    Console.WriteLine("Whom do you want to transfer the money?\n");
                    for(int i=0;i<a.Length-1;i++)
                    {
                        if(a[i]!=null)
                        {
                            Console.WriteLine("--------------------------");
                            Console.WriteLine(i + ":" + a[i].Name + "\n");

                        }
                        else
                        {
                            break;
                        }
                        
                    }
                    Console.WriteLine("Enter serial no:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter amount:");
                    Double am3 = Convert.ToDouble(Console.ReadLine());
                    a[ab].Transfer(a[x], am3);
                    input = "account";
                    this.Menu();

                    break;

                case "withdraw":


                    Console.WriteLine("____________________________________"); 
                    Console.WriteLine("Enter amount:");
                    Double am1 = Convert.ToDouble(Console.ReadLine());

                    a[ab].Withdraw(am1);
                    input = "account";
                    a[ab].Transactions++;
                    this.Menu();

                    break;

                case "show":

                    Console.WriteLine("____________________________________");
                    a[ab].show();
                    input = "account";
                    this.Menu();
                    break;
                case "exit":
                    System.Environment.Exit(0);
                    break;
            }
        }

        public void Create(String name,String dob,String address,String type)
        {
            for (int i = 0; i < 10; i++)
            {


                if (a[i] == null)
                {
                    a[i] = new Account(name,dob,address,type);
                    ab = i;

               
                    Console.WriteLine("Account addeed!");
                    break;
                }


            }

        }

    }
}
