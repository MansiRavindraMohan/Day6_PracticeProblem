using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_PracticeProblem
{
    public class SortingLinkedList
    {
        public void SortingMethod()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            // Insert elements in descending order
            InsertSortedDescending(linkedList, 40);
            InsertSortedDescending(linkedList, 10);
            InsertSortedDescending(linkedList, 30);
            InsertSortedDescending(linkedList, 20);
            InsertSortedDescending(linkedList, 50);

            // Print the LinkedList
            Console.WriteLine("Elements in the LinkedList:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        public static void InsertSortedDescending(LinkedList<int> list, int value)
        {
            LinkedListNode<int> current = list.First;

            // Find the position where the new element should be inserted
            while (current != null && current.Value > value)
            {
                current = current.Next;
            }

            // Insert the new element at the appropriate position
            if (current != null)
            {
                list.AddBefore(current, value);
            }
            else
            {
                list.AddLast(value);
            }
        }
    }
}
