using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class QueueArray
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public QueueArray()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public QueueArray(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return (front == -1 || front == rear + 1);
        }

        public bool IsFull()
        {
            return (rear == queueArray.Length - 1);
        }

        public int Size()
        {
            if (IsEmpty())
                return 0;
            else
                return rear - front + 1;
        }

        public void Insert(int x)
        {
            if (IsFull())
            {
                WriteLine("Queue is full");
                return;
            }
            if (front == -1)
                front = 0;
            rear = rear + 1;
            queueArray[rear] = x;
        }

        public int Delete()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            return queueArray[front];
        }

        public int Peek()
        {
            if(IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            return queueArray[front];
        }

        public void Display()
        {
            if(IsEmpty())
            {
                WriteLine("Queue is empty");
                return;
            }
            WriteLine("Queue is: ");
            for(int i = front; i <= rear; i++)
            {
                Write($"{queueArray[i]} ");
            }
            WriteLine();
        }
    }
}
