using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class StringPalindrome
    {

        public static void Main(string[] arhs)
        {

            string s1 = "ajit";

            string rev = "";

            for (int i = s1.Length - 1; i >= 0; i--)
            {

                rev += s1[i];


            }

            if (s1 == rev)
            {

                Console.WriteLine("Given String Is Palindrome String:");

            }

            else
            {

                Console.WriteLine("Given String Is Not Palindrome:");

            }




        }
    }
}
