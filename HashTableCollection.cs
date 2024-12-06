using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class HashTableCollection
    {
        public static void Main()
        {
            Console.WriteLine("********* Hashtable**********");
            Console.WriteLine();

            Hashtable   ht = new Hashtable();
            ht.Add("a", 1);
            ht.Add("b", 2);
            ht.Add("c", 3);
           ht.Add("d", 4);
           ht.Add("e", 5);

            Console.WriteLine("HashCode Table");
            foreach (var item in ht)
            { 
           
            Console.WriteLine(item);
            
            }
            Console.WriteLine();

            Console.WriteLine("1)After Performing Remove Operation=");


            ht.Remove("a");

            foreach (var item1 in ht)
            { 
            
             Console.WriteLine(item1);
            
            }


            Console.WriteLine();
            Console.WriteLine("After Perform Delete Opration All HastTable Table Will Be Delete=");
             ht.Clear();

            foreach (var item2 in ht)
            { 
            
            Console.WriteLine(item2);
            
            
            }

            

        }
    }
}
