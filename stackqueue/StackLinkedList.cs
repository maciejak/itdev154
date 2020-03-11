using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class StackLinkedList
    {
        private Node top;

        public StackLinkedList()
        {
            top = null;
        }

        public int Size()
        {
            int s = 0;
            Node p = top;
            while (p!= null)
            {
                p = p.link;
                s++;
            }
            return s;
        }

        public void Push(int x)
        {
            Node temp = new Node(x);
            temp.link = top;
            top = temp;
        }

        public bool IsEmpty()
        {
            return (top == null);
        }

        public int Pop()
        {
            int x;
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack Underflow");
            }
            x = top.info;
            top = top.link;
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack Underflow");
            }
            return top.info;
        }

        public void Display()
        {
            Node p = top;
            if(IsEmpty())
            {
                WriteLine("Stack is empty");
                return;
            }
            WriteLine("Stack is: ");
            while(p!= null)
            {
                Write($"{p.info} ");
                p = p.link;
            }
            WriteLine();
        }
    }
}
