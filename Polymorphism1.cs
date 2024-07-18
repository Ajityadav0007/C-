using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Shape1
    {
        public  virtual void draw()
        {
            Console.WriteLine("I am Drawing The Shape");

        }
    }
    public class circle1 : Shape1

    {

        public override void draw()
        {
            Console.WriteLine("I am Drawing Circle");

        }

    }

    public class Square : Shape1
    {

        public override void draw()
        {

            Console.WriteLine("I am Drawing Square");


        }


    }

    public class pro
    {

        public static void Main(string[] args)
        {

            // s = new Shape();
           // s.draw();

//Shape c = new circle();

           // c.draw();

          ////  Shape sd =new Square();

           // sd.draw();





        }



    }
}


   


    
    
