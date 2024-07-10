using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class arrayprime
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 12, 13, 134, 342, 1324 };
            Console.WriteLine("Given Array=:");

            for (int i = 0; i < numbers.Length; i++)
            { 
              Console.WriteLine(numbers[i]);
          
            }

            foreach (int number in numbers)
            {
                bool isPrime = true;

                if (number <= 1)
                {
                    isPrime = false;
                }
                else if (number == 2)
                {
                    isPrime = true;
                }
                else if (number % 2 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 3; i <= Math.Sqrt(number); i += 2)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("prime number is= "+number);
                }
             
            }
        }
    }
}