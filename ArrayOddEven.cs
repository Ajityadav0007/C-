using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayOddEven
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 15, 40, 50 };
           
             int evenindex = 0;
            int oddindex = 0;   
            int[] even = new int[arr.Length];
            int[] odd= new int[arr.Length];

            Console.WriteLine("Even No =");
           

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[evenindex] = arr[i];
                    evenindex++;





                }

              



            }

            Console.WriteLine("Even No =");

            for (int i = 0; i < evenindex; i++)

            {
                Console.WriteLine(even[i]);
                
                if (i < evenindex - 1)
                {
                    Console.WriteLine();
                }
            }







            Console.WriteLine("Odd No" + odd);
          

        }
       
      
    }

}