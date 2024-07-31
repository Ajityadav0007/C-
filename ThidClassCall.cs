using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ThidClassCall
    {
        public static void Main()
        {

            Console.WriteLine("******* Extension Method*******");

            FirstClassOld k = new FirstClassOld();
            k.Add(10);
            k.Sub(10,2);
            k.multi(11,2);
            k.div(11,3);

        }
       
        
    }
}
