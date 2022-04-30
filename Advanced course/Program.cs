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
            var input = Console.ReadLine();
            var command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "Stack")
                {
                    Stack.methodStack(input);
                    command = Console.ReadLine();
                }
                else if (command == "Queue")
                {
                    Queue.methodQueue(input);
                    command = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("wrong command ! Choose between \"Stack\" or \"Queue\"");
                    command = Console.ReadLine();

                }
            }
        }
    }

}
