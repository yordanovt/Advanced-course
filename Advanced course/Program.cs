using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input  = Console.ReadLine();
            var demoStack = new Stack<char>();
            var demoQueue = new Queue<char>();

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
            foreach (var item in input)
            {
                demoQueue.Enqueue(item);
                Console.WriteLine(item);
            }

            while (demoQueue.Count != 0)
            {
                Console.Write(demoQueue.Dequeue());
            }
            Console.WriteLine();


        }
    }
}
