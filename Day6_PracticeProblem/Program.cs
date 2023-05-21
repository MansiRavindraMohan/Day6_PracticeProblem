using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_PracticeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListClass linkedListClass = new LinkedListClass();
            linkedListClass.MethodLinkedList();

            StackClass stackClass= new StackClass();
            stackClass.MethodStack();

            QueueClass queueClass = new QueueClass();
            queueClass.MethodQueue();

            SortingLinkedList sortingLinkedList = new SortingLinkedList();
            sortingLinkedList.SortingMethod();
            Console.ReadLine();
        }
    }
}
