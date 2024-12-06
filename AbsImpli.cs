using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

        public string Display(string s)
        {
           Console.WriteLine(s);    
            return s;

        }


    }


    public class Rectangle : Shape
    {
        public override double CalculateArea()
        {
            double len = 10.2;
            double wid = 12;

            return len * wid;

           


        }


    }

    public class Circlr : Shape
    {
        public override double CalculateArea()
        {
            double Red = 10.2;
            

            return 3.14*Red*Red;

           


        }
    }


    public class AbsImpli
    {

        public static void Main()
        { 
        
          Rectangle r=new Rectangle();
            Circlr c = new Circlr();

            r.Display("Rectangle Area Calculate=");
            
            Console.WriteLine(" Area of Rectangle =" + r.CalculateArea());
            c.Display("circle Area Calculate=");
          
            Console.WriteLine(" Area Circle =" + c.CalculateArea());

           


        }
    
    
    }
}