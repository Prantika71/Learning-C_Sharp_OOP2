using System;
using System.Collections.Generic;
using System.Text;

namespace Test_2
{
   public  class Student
    {
        private string name;
        private double cgpa;
        private string id;

        public string Name { get => name; set => name = value; }
        public double Cgpa { get => cgpa; set => cgpa = value; }
        public string Id { get => id; set => id = value; }

        public void showinfo()
        {
            Console.WriteLine(this.name+"\n");
            Console.WriteLine(this.cgpa + "\n");
            Console.WriteLine(this.id + "\n");
            Console.WriteLine("........................");
        }
    }
     
}
