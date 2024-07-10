using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArraySum

    {

        public static void Main()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int[] arr1 = { 50, 40, 30, 20, 10 };
            int[] sum = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)

            {
                sum[i] = arr[i] + arr1[i];

            }



            Console.WriteLine("Sum Array: [" + string.Join(", ", sum) + "]");

        }
    }
}