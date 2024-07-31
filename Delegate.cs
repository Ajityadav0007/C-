using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Delegate
    {

       
        public delegate void Delegatedel1(int a,int b);
        public delegate void Delegatedel(int x,int y);

        public void add(int a,int b)
        {
            Console.WriteLine("****** SingleCast Deligate ******");

            Console.WriteLine("Addition="+(a+b));

            
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("Substration="+(x-y));

        }

        public void display()
        {
            Delegatedel1 del1 = add;
            Delegatedel del2 = sub;

            del1(10, 5);
            del2(10, 5);

        }

    }
    class Deli4
    {
        public static void Main()
        {

            Delegate del = new Delegate();
            del.display();




        }
    
    
    }
}
