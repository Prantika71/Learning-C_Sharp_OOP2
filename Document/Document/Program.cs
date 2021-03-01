using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
           
            University u = new University();
            Student s1 = new Student("Sneha", 4.00, "18-37385-1");
            Student s2 = new Student("Durjoy", 3.99, "18-33622-1");
            u.AddStudent(s1);
            u.AddStudent(s2);

            u.getStudent();
        }
    }
}
