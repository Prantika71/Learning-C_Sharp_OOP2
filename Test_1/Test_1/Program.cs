using System;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            xm a = new xm();
            a.Name = "Durjoy";
            a.Age = 22;
            a.Cgpa = 3.49;
            xm b = new xm(60,"Atisa",9.00) ;
           

            Console.WriteLine("NAME :"+a.Name+"\n"+"Age:"+a.Age+"\n"+"CGPA :"+a.Cgpa+"\n"+"-----------------");
            



        }
    }
}
