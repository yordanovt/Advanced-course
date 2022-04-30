using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_course
{
    internal class Stack
    {
        public static void methodStack(string input)
        {
            var demoStack = new Stack<char>();

            foreach (var item in input)
            {
                demoStack.Push(item);
                Console.WriteLine(item);
            }
            while (demoStack.Count != 0)
            {
                Console.Write(demoStack.Pop());
            }
            Console.WriteLine();

            
        }
    }
}
