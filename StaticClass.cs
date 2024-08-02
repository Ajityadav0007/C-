using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class StaticClass
    {
        
            public static void Main()
            {

            Console.WriteLine("****Static Class*****");
                CatWorld.AddCat();
                CatWorld.AddCat();
                CatWorld.AddCat();
            CatWorld.AddCat();
;               

               
              Console.WriteLine($"Final count Cats: {CatWorld.NumberOfCats}, Naps: {CatWorld.NumberOfNaps}");
            }
        }

    }

    public static class CatWorld
        {
           
            private static int numberOfCats;
            private static int numberOfNaps;


            public static int NumberOfCats
            {
            get { return numberOfCats; }
            }

           
            public static int NumberOfNaps
            {
                get { return numberOfNaps; }
            }


            public static void AddCat()
            {
                numberOfCats++;
                numberOfNaps++;
                Console.WriteLine($"A new cat has been added! Total cats: {numberOfCats}. Total naps: {numberOfNaps}.");
            }
        }
    

   
