using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private Node start; //always refers to first node of the list

        public LinkedList()
        {
            start = null;
        }

        public void InsertAtBeginning(int data)
        {
            Node temp = new Node(data); //create new node

            if (start == null)
            {
                temp.link = start; //set the temporary node link as precedent to start
                start = temp; //set start to the info of the temporary node
            }
        }

        public void DeletFirstNode()
        {
            if (start == null)
                return;
            start = start.link; //set start equal to the second node, deleting the first
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);
            if (start == null) //if the list is empty, make start refer to the new node
            {
                start = temp;
                return;
            }

            else
            {
                p = start;
                while (p.link != null) //find reference to last node of the link
                    p = p.link;
                p.link = temp;
            }
        }

        public void DeleteLastNode()
        {
            if(start == null) //if list is empty make start null
                return;
            if (start.link == null) //if list is only one node make start null
            {
                start = null;
                return;
            }

            Node p = start;
            while (p.link.link != null) //find reference to second last node of the list
                p = p.link;
            p.link = null; //the last node becomes null
        }

        public void InsertAtPosition(int x, int data)
        {
            Node temp;
            int i;

            if(x == 1) //if we are inserting into the first position, just set it to start
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            for (i = 1; i < x - 1 && p != null; i++) //find reference to x-1
                p = p.link;

            if (p == null)
            {
                WriteLine();
                WriteLine("You can only insert up to position " + x + ".");
            }

            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

            return;
        }

        public int CountNodes()
        {
            int n = 0;
            Node p = start;
            while(p != null)
            {
                n++;
                p = p.link;
            }
            return n;
        }

        public void RemoveAtPosition(int x)
        {
            int i;
            int n = CountNodes();

            if (start == null)
            {
                WriteLine("List is empty.");
                return;
            }

            if (n < x) //check for valid input
            {
                WriteLine("You can only remove up to position " + n + ".");
                return;
            }

            if (x == 1)
            {
                start = null;
                return;
            }

            Node p = start;
            for (i = 1; i < x-1 && p != null; i++)
                p = p.link;

            p.link = p.link.link;           
        }

        public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = start;
            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }

        public void BubbleSortExData()
        {
            Node end, p, q;
            for (end = null; end != start.link; end = p)
            {
                for(p = start; p.link != end; p =p.link)
                {
                    q = p.link;
                    if(p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        public void BubbleSortExLinks()
        {
            Node end, r, p, q, temp;
            for (end = null; end != start.link; end = p)
            {
                for (r = p = start; p.link != end; r = p, p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;
                        if (p != start)
                            r.link = q;
                        else
                            start = q;
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }

        public void InsertCycle(int data)
        {
            if (start == null)
                return;

            Node p = start, px = null, prev = null;

            while (p != null)
            {
                if (p.info == data)
                    px = p;
                prev = p;
                p = p.link;
            }
            if (px != null)
                prev.link = px;
            else
                WriteLine(data + " not present in list.");
        }

         public bool HasCycle()
         {
            if (FindCycle() == null)
                return false;
            else
                return true;
         }

        private Node FindCycle()
        {
            if (start == null || start.link == null)
                return null;

            Node slowR = start, fastR = start;

            while (fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;
                if (slowR == fastR)
                    return slowR;
            }
            return null;
        }

        public void RemoveCycle()
        {
            Node c = FindCycle();
            if (c == null)
                return;
            WriteLine("The node at which the cycle was detected is: " + c.info + ".");

            Node p = c, q = c;
            int lenCycle = 0;
            do
            {
                lenCycle++;
            } while (p != q);
            WriteLine("The length of the cycle is: " + lenCycle);

            int lenRemList = 0;
            p = start;
            while (p != q)
            {
                lenRemList++;
                p = p.link;
                q = q.link;
            }

            WriteLine("The number of nodes not included in this cycle are: " + lenRemList + ".");

            int lengthList = lenCycle + lenRemList;
            WriteLine("The length of the list is: " + lengthList + ".");

            p = start;
            for (int i = 1; i <= lengthList - 1; i++)
                p = p.link;
            p.link = null;
        }

        public void CreateList()
        {
            int i, n, data;
            WriteLine();
            Write("Enter the number of nodes: ");
            n = Convert.ToInt32(ReadLine());

            if (n == 0)
                return;
            for (i = 1; i <= n; i++)
            {
                Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(ReadLine());
                InsertAtEnd(data);
            }
        }

        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                WriteLine("List is empty.");
                Program.GetUserSelection();
            }

            else
            {
                WriteLine("List is: ");
                p = start; //initialize p 
                while (p != null)
                {
                    Write(p.info + " "); //display node info
                    p = p.link; //set p to next item in list
                }
                WriteLine();
                Program.GetUserSelection();
            }
        }
    }
}
