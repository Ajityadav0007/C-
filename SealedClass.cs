using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class SealedClass
    {
        public static void Main()
        {
            Console.WriteLine("***Sealed Class ****");
            Base @base = new Base();

            @base.sell();

            Der der = new Der();
            der.Display();


        }



    }

    public sealed class Base
        {

        protected int i = 40;
        protected int j = 20;

        public void sell()
        {

            Console.WriteLine("Substration="+(i-j));
    ;
            
        }
        
        }
    public class Der//:Base// he cant Run Because Base Apply Sealed Class That He Cant Be Derive
        
    {
        int i = 10;
        int j = 20; 
        public void Display()
        {
            Console.WriteLine("Addition="+(i+j));
        
        
        }
    
    
    
    }

}
