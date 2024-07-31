using System;

namespace Array
{
    public class SingleInheritance
    {
        public static void Main()
        {
            Student student = new Student();
            student.Display();
        }
    }

    public class Person
    {
        protected string name = "Ajit";
        protected int age = 21;


        public void GetInfo()
        {
            Console.WriteLine();
            
        }
    }

    public class Student : Person
    {

        int StdId = 2194;
        public void Display()
        {
            Console.WriteLine($"Student Information =\nName: {name},\nAge: {age} ,\nStdId={StdId}");

        }
    }
}
