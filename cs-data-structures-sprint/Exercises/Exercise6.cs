using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise6
    {
        public static void PrintQueue<T>(Queue<T> queue)
        {
            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine(queue.ElementAt(i));
            }
        }

        public static Queue<T> ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stackedQueue = new();
            int queueSize = queue.Count;
            for (int i = 0; i < queueSize; i++)
            {
                T numberDeQueued = queue.Dequeue();
                stackedQueue.Push(numberDeQueued);
            }
            queue = new Queue<T>(stackedQueue.ToArray());            
            return queue;
         
        }

        

    }
}
