using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class StackClass
    {
        private int[] items;
        private int top;
        private int maxSize;

        public StackClass(int size)
        {
            maxSize = size;
            items = new int[maxSize];
            top = -1;
        }

        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine(" Stack Overflow! Cannot push " + item);
                return;
            }
            items[++top] = item;
            Console.WriteLine(item + " pushed to stack.");
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine(" Stack Underflow! Cannot pop.");
                return -1;
            }
            return items[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine(" Stack is empty.");
                return -1;
            }
            return items[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }
    }

}
