using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{

    enum month
        { 
             january,
             feb,
             march,
             april,
             May,
             June,
             July,
             August,
             Sep,
             Nov,
             December
    
        }
    internal class Enum
    {
        public static void Main(string[] args)
        {
            month month = new month();
            month1 = month.December;
            month = month.january;
            switch (month)
            { 
            
                case month.january:
                    Console.WriteLine("It is Starting month Is January");
                    break;

                case month.feb:
                    Console.WriteLine("It is Noramal month");
                    break;
                case month.march:
                    Console.WriteLine("It is Noraml month");
                    break;
                case month.april:
                    Console.WriteLine("It is Normal month");
                    break;
                case month.December:
                    Console.WriteLine("It is End od Month  month");
                    break;

            }
        
        
        }

    }
}
