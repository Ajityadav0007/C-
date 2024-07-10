using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Search
    {
        public static void Main(string[] args)

        {
            String find=Convert.ToString(Console.ReadLine());
            
            string[] search = { "Alice", "Bob", "Charlie", "David", "Emily" };
             bool isFount =false;
            foreach (string s in search)
            {
              
               
                if (s == find)
                {
                    Console.WriteLine("Bob Will be Find " + s);

                    isFount = true;

                    break;

                }
               
            
            }

           if (!isFount) 
            {

                Console.WriteLine("bob Cannot be Find");
            }


        }
    }
}
