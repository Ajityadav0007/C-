using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class StackCollection
    {
        public static void Main()
        {

            Console.WriteLine("******** Genric Stack Implimentation************");
        Stack<int> stack = new Stack<int>();
            

           stack.Push(101);
            stack.Push(102);
            stack.Push(103);
            stack.Push(104);
            stack.Push(105);

            Console.WriteLine("All Stack Value=");

            foreach (int i in stack)
            { 
            
            Console.WriteLine(i);
            
            }

           

            object t= stack.Pop();
            object y= stack.Pop();
            object z= stack.Pop();
            object m= stack.Pop();
            object k = stack.Pop();
        

            Console.WriteLine($"Pooped Element..........=\n{t}\n{y}\n{z}\n{m}\n{k}");
            



            if (stack.Count == 0)
            {

                Console.WriteLine("Stack Is Empty");

            }
            else
            { 
            
            Console.WriteLine("stack is not Empty");
            
            }

        }

    }
}
