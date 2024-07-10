using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class alterArray
    {
        public static void Main(string[] args)
        {

            int[] alt = { 1, 2, 3, 4, 5,6 };

            int min =alt[0];
            int max =alt[0];    

            Console.WriteLine("Given Array=");
            for(int j=0;j<alt.Length;j++)
            {
                Console.WriteLine(alt[j]);
            }

            Console.WriteLine("Alternative  Element=");

            for(int i=1;i<alt.Length;i+=2)
            {

              
                 
                Console.WriteLine(alt[i]);


                
          


            }


            Console.WriteLine("********************************");

           int cout= alt.Count();

            Console.WriteLine("Count Of Array="+cout);

            for (int k = 0; k < alt.Length; k++)
            {

                if (alt[k] < min)
                { 
                
                min= alt[k];
                
                }

                if (alt[k] > max)
                { 
                
                max= alt[k];
                
                }
            
            }

            Console.WriteLine("Smallest number of Array="+min);
            Console.WriteLine("Largest number of Array=" + max);

        }

        
    }
    
}
