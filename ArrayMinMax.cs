using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayMinMax
    {
        public static void Main(String[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            

            int min = arr[0];
            int max = arr[0];

            Console.WriteLine("Given Array :-");

            foreach (int a in arr)
            { 
            
             Console.WriteLine(a);
            
            }

            

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min= arr[i];


                }

                if (arr[i] > max)
                {
                  max= arr[i];
                    
                
                
                }
            
            
            }

           

            Console.WriteLine("Minimum Number Of array=" + min);
            Console.WriteLine("Maximum Number Of array=" + max);

        }

    }
}
