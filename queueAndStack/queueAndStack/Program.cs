using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueAndStack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var queue = new Queue();
            var stack = new Stack();

            for (int i = 1; i <= 10; i++)
            {
                queue.Push(i);
                stack.Push(i);
            }

            Console.WriteLine($"number of queue elements: {queue.Length}, number of stack elements: {stack.Length}");
            Console.WriteLine();
            
            while (queue.Length > 0)
            {
                Console.WriteLine($"Popping out of queue: {queue.Pop()}");
            }
            Console.WriteLine();
            while (stack.Length > 0)
            {
                Console.WriteLine($"Popping out of stacks: {stack.Pop()}");
            }

            Console.ReadKey();
        }
    }
}
