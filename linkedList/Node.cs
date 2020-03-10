using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int info; //data that is stored in the list
        public Node link; //of type Node; always refers to the next Node in the list

        public Node(int i)
        {
            info = i; //info initialized with i
            link = null; //link initialized to null
        }
    }
}
