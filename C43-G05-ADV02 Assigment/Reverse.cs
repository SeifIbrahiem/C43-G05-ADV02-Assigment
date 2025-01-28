using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV02_Assigment
{
    internal class Reverse
    {
        public static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> s = new Stack<int>();

            // Enqueue all elements of the queue to the stack
            while (queue.Count > 0)
            {
                s.Push(queue.Dequeue());
            }

            // Dequeue all elements from the stack and enqueue them back to the queue
            while (s.Count > 0)
            {
                queue.Enqueue(s.Pop());
            }
        }
    }
}
