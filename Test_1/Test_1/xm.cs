using System;
using System.Collections.Generic;
using System.Text;

namespace Test_1
{
    public class xm
    {
        private String name;        
        private int age;
        private double cgpa;
        public xm()
        {
        }
        public xm(int age,String name,double cgpa)
        {
            this.Name = name;
            this.age = age;
            this.cgpa = cgpa;

        }
        public int Age { get => age; set => age = value; }
 
        public double Cgpa { get => cgpa; set => cgpa = value; }
        public string Name { get => name; set => name = value; }
    }
}
