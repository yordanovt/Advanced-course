using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_course
{
    internal class Queue
    {
        public static void methodQueue(string input)
        {
            var demoQueue = new Queue<char>();

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
