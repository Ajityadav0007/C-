using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayListCollection
    {
        public static void Main()
        {
            Console.WriteLine("******* ArrayList*******");
         ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.Add(70);
            list.Add(80);
            list.Add(90);
            list.Add(100);

            Console.WriteLine("ArrayList=");

            foreach (var item in list)
            { 
            
            Console.WriteLine(item);
            
            }
            Console.WriteLine();
            Console.WriteLine("After Performing RemoveOperation=");
            list.Remove(50);
            list.Remove(60);

            foreach (var item1 in list)
            {

                Console.WriteLine(item1);

            }
            Console.WriteLine();

            Console.WriteLine("After Performing Delete Operation All ArrayList Will Be Delete=");





        }

       

        

    }
}
