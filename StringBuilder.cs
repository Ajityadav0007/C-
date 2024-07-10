using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
 

public class program
{
    public static void Main(string[] args)
    {
       // string msg = "Ajuu ";
       // msg += "yadav";
       // Console.WriteLine(msg); 

        StringBuilder sb = new StringBuilder(" code");

            Console.WriteLine("Perform Append operation:-");
            Console.WriteLine();


            sb.Append("Technology");

            Console.WriteLine("Append String="+ sb);
            Console.WriteLine   ();

            Console.WriteLine("*************************");
            Console.WriteLine("perform Replace operation:-");
            Console.WriteLine();

            Console.WriteLine("Before Replace ="+sb);


            sb.Replace("code", "codemind");

            Console.WriteLine("After Replaces="+ sb);

            Console.WriteLine("*************************");
           

            Console.WriteLine("Perform Remove Operation:-");
            Console.WriteLine();

            Console.WriteLine("Before Removing="+sb);

            sb.Remove(5,4);

            Console.WriteLine("After Removing="+sb);

           




        }
}

}
