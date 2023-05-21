using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_PracticeProblem
{
    public class QueueClass
    {
        public void MethodQueue()
        {
            Queue<int> queue = new Queue<int>();

            // Create : Enqueue elements into the queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            // Read : Print the elements of the queue
            Console.WriteLine("Elements in the queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Update : Dequeue the front element and enqueue an updated value
            int dequeuedValue = queue.Dequeue();
            queue.Enqueue(dequeuedValue + 5);

            // Read : Print the elements of the queue after update
            Console.WriteLine("Elements in the queue after update:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Delete : Dequeue an element from the queue
            int removedValue = queue.Dequeue();

            // Read : Print the elements of the queue after deletion
            Console.WriteLine("Elements in the queue after deletion:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Clear : Clear all elements from the queue
            queue.Clear();

            // Read : Print the elements of the queue after clearing
            Console.WriteLine("Elements in the queue after clearing:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
