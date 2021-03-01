using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.Name = Console.ReadLine();
            a.Cgpa =Convert.ToDouble(Console.ReadLine()) ;
            a.Id = "898-89";
            Student b = new Student();
            b.Name = "yy";
            b.Cgpa = 7.0;
            b.Id = "798-89";
            Student c = new Student();
            
            c.Name = "zz";
            c.Cgpa = 8.0;
            c.Id = "898-89";

     

            a.showinfo();
            b.showinfo();
            c.showinfo();

            
        }
    }
}
