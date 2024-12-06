using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class DeligateMulti
    {


        public delegate void Delegatedel1(int a, int b);
        

        public void add(int a, int b)
        {
            Console.WriteLine("****** MultiCast Deligate ******");

            Console.WriteLine("Addition=" + (a + b));


        }

        public void sub(int a, int b)
        {
            Console.WriteLine("Substration=" + (a- b));

        }

        public void mul(int a, int b)
        {
            Console.WriteLine("Multiplication=" + (a * b));

        }

        public void display()
        {
            Delegatedel1 del1 = add;
            Delegatedel1 del2 = sub;
            Delegatedel1 del3 = mul;

            del1(10, 5);
            del2(10, 5);
            del3(11,2);

        }

    }
    public class pro1
    {
        public static void Main()
        {

            DeligateMulti del = new DeligateMulti();
            del.display();




        }

    }
}
