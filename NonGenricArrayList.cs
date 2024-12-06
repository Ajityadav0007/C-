using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class NonGenricArrayList
    {
        public static void Main()
        {
            ArrayList list = new ArrayList();
            

            list.Add("Ajit");
            list.Add("4190");
            list.Add("77.10");

            Console.WriteLine("ArrayList");

            foreach (object item in list)
            { 
            
            Console.WriteLine(item);
            
            }

            Console.WriteLine();
            Console.WriteLine("After Remove The Element On NonGenricArrayList=");

             list.Remove("Ajit");


           

        }


    }
}
