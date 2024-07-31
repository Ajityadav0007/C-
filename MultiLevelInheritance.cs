using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class MultiLevelInheritance
    {
        public static void Main()
        {
            Principle principle = new Principle();  
            principle.GetInfo();
        }
    }

    public class Person1
    {
        protected string name = "Ajit Yadav";
        protected int RollNo = 2194;


    }

    public class Teacher : Person1
    {

        protected int Marks = 80;



    }

    public class Principle:Teacher
    {
        protected string Grade = "A+";

        public void GetInfo()
        {
            Console.WriteLine($"Student Report Card=\nName={name} \nRollNo={RollNo} \nMarks={Marks} \nGrade={Grade}");
        
        }

    }
}
