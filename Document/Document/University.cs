using System;
using System.Collections.Generic;
using System.Text;

namespace Document
{
    public class University
    {
        Student[] students;
        static int noOfStudent = 0;

        public University()
        {
            students = new Student[40];
        }

        public void AddStudent(Student s)
        {
            students[noOfStudent++] = s;
        }
        
        public void getStudent()
        {
            int i = 0;
            while (students[i] !=null)
            {
                Console.WriteLine("Name:" + students[i].Name);
                Console.WriteLine("Id:" + students[i].Id);
                Console.WriteLine("Cgpa:" + students[i].Cgpa);
                Console.WriteLine();
                i++;
            }
        }
    }
}
