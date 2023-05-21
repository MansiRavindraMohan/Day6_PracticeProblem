using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_PracticeProblem
{
    public class StackClass
    {
        public void MethodStack()
        {
            Stack<int> stack = new Stack<int>();

            // Create : Push elements onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            // Read : Print the elements of the stack
            Console.WriteLine("Elements in the stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Update : Pop the top element and push an updated value
            int poppedValue = stack.Pop();
            stack.Push(poppedValue + 5);

            // Read : Print the elements of the stack after update
            Console.WriteLine("Elements in the stack after update:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Delete : Pop an element from the stack
            int removedValue = stack.Pop();

            // Read : Print the elements of the stack after deletion
            Console.WriteLine("Elements in the stack after deletion:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Clear : Clear all elements from the stack
            stack.Clear();

            // Read : Print the elements of the stack after clearing
            Console.WriteLine("Elements in the stack after clearing:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
