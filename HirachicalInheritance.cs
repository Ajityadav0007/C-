using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class HirachicalInheritance
    {
        public static void Main()
        { 
        
            Circle c = new Circle();
            c.CircleGetINfo();
            Rectangle11 r=new Rectangle11();
            r.RectangleGetINfo();
        
        
        }
    }

    public  class Shape11
    {
        protected string Color = "RED";

        protected int Size = 21;

    
    }

    public class Circle : Shape11
    {

        protected string Name = "Circle";
        protected double Rad = 11.2;

        public void CircleGetINfo()
        {
            Console.WriteLine($"1:INformation Of Shape: \nNameOfShape={Name} \nSizeOfShape={Size} \nColorOfShape={Color} \nRadiusOf Shape={Rad}");
            Console.WriteLine();
        }




    }

    public class Rectangle11 : Shape11
    {
        protected string Name = "Rectangle";
        protected double Height = 10;
        protected double Width = 11;

        public void RectangleGetINfo()
        {
            Console.WriteLine();
            Console.WriteLine($"2:INformation Of Shape: \nNameOfShape={Name} \nSizeOfShape={Size} \nColorOfShape={Color} \nHeightOfShape={Height} WidthOfShape={Width}");


        }
    
    
    
    }

}
