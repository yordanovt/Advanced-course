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
            var demo = new Stack<char>();
           
            foreach (var item in input)
            {
                demo.Push(item);
                Console.WriteLine(item);
            }
            
            while (demo.Count!=0)
            {
                Console.Write(demo.Pop());
            }
            Console.WriteLine("this is a change to add in github for testing purpose");
            
        }
    }
}
