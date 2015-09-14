using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackingUpPoppingItOut_HAHA
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();

            
        }
    }
}
