using System;
using System.Collections.Generic;
using System.Text;

namespace Document
{
    public class Student
    {
        private string name;
        private double cgpa;
        private string id;

        public string Name { get => name; set => name = value; }
        public double Cgpa { get => cgpa; set => cgpa = value; }
        public string Id { get => id; set => id = value; }
        public Student() { }

        public Student(String name, double cgpa, string id)

        {
            this.name= name;
            this.cgpa=cgpa;
            this.id=id;


        }
    }





   

}
