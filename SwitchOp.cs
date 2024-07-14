using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class SwitchOp
    {
        public static void Main()

        {
            Console.WriteLine("\nEnter Your Choice=");
            Console.WriteLine("\n1)Operators\n2)ConditionalStatement \n3)Looping Statement \n3)Array");
            int x = Convert.ToInt16(Console.ReadLine());

            do
            {
                switch (x)
                {

                    case 1:
                        Console.WriteLine("Choose the Operator=");
                        Console.WriteLine("\n1:Addition \n2:Substartion\n3:Multiplication\n4:Division");
                        int op = Convert.ToInt16(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("Enter First No=");
                                int a = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Enter Second No=");
                                int b = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Addition=" + (a + b));

                                break;
                            case 2:
                                Console.WriteLine("Enter First No=");
                                int a2 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Enter Second No=");
                                int b2 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Addition=" + (a2 - b2));

                                break;

                            case 3:
                                Console.WriteLine("Enter First No=");
                                int a1 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Enter Second No=");
                                int b1 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Multiplication=" + (a1 * b1));

                                break;


                            case 4:
                                Console.WriteLine("Enter First No=");
                                int x1 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Enter Second No=");
                                int y1 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Division=" + (x1 / y1));

                                break;


                        }


                        break;


                }

                Console.ReadLine();


            } while (x != 5);
            }
    }
}
