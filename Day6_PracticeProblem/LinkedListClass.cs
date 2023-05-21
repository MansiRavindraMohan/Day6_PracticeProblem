using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_PracticeProblem
{
    public class LinkedListClass
    {
        public void MethodLinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add elements to the LinkedList
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            linkedList.AddLast(50);

            // Read: Print the elements of the LinkedList
            Console.WriteLine("Elements in the LinkedList:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Update: Update an element in the LinkedList
            LinkedListNode<int> nodeToUpdate = linkedList.Find(30);
            if (nodeToUpdate != null)
            {
                nodeToUpdate.Value = 35;
            }

            // Read: Print the elements of the LinkedList after update
            Console.WriteLine("Elements in the LinkedList after update:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Delete: Remove an element from the LinkedList
            linkedList.Remove(40);

            // Read: Print the elements of the LinkedList after deletion
            Console.WriteLine("Elements in the LinkedList after deletion:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Clear the LinkedList
            linkedList.Clear();

            // Read: Print the elements of the LinkedList after clearing
            Console.WriteLine("Elements in the LinkedList after clearing:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
