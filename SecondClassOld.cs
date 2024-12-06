using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public static class SecondClassOld
    {
        public static void Sub(this FirstClassOld old,int y,int z)
        {
            Console.WriteLine($"Substration={old.x-y -z}");
        
        
        }
        public static void multi(this FirstClassOld old, int y, int z)
        {
            Console.WriteLine($"Multiplication={old.x * y * z}");


        }
        public static void div(this FirstClassOld old, int y, int z)
        {
            Console.WriteLine($"Division={old.x / y / z}");


        }

    }
}
