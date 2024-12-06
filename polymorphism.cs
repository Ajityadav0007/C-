using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{

   public  class Polymorphism
    {

        public static void Main(string[] args)
        {
            //Method overloading

            Pol p = new Pol();

            p.Sum(10, 21);

            p.Sum(11.2, 11.3, 11);


        }
        internal class Pol
    {

        public void Sum(int a, int b)
        {

            Console.WriteLine($"Addition={a+b}");
        
        }

        public void Sum(double a, double b, double c)
        {

            Console.WriteLine($"Addition={a+b+c}");
        
        }

    }

   

    }

    }

