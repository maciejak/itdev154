using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Display()
        {
            Display(root, 0);
            WriteLine();
        }

        private void Display(Node p, int level)
        {
            int i;

            if (p == null)
                return;

            Display(p.rchild, level + 1);
            WriteLine();

            for (i = 0; i < level; i++)
                Write("     ");
            Write(p.info);

            Display(p.lchild, level + 1);
        }

        public void Preorder()
        {
            Preorder(root);
            WriteLine();
        }

        private void Preorder(Node p)
        {
            if (p == null)
                return;
            Write($"{p.info} ");
            Preorder(p.lchild);
            Preorder(p.rchild);
        }

        public void Inorder()
        {
            Inorder(root);
            WriteLine();
        }

        private void Inorder(Node p)
        {
            if (p == null)
                return;
            Inorder(p.lchild);
            Write($"{p.info} ");
            Inorder(p.rchild);
        }

        public void Postorder()
        {
            Postorder(root);
            WriteLine();
        }

        private void Postorder(Node p)
        {
            if (p == null)
                return;
            Postorder(p.lchild);
            Postorder(p.rchild);
            Write($"{p.info} ");
        }

        public void LevelOrder()
        {
            if (root == null)
            {
                WriteLine("Tree is empty.");
                return;
            }

            Queue<Node> qu = new Queue<Node>();
            qu.Enqueue(root);

            Node p;
            while (qu.Count != 0)
            {
                p = qu.Dequeue();
                Write($"{p.info} ");
                if (p.lchild != null)
                    qu.Enqueue(p.lchild);
                if (p.rchild != null)
                    qu.Enqueue(p.rchild);
            }
            WriteLine();
        }

        public int Height()
        {
            return Height(root);
        }

        private int Height(Node p)
        {
            if (p == null)
                return 0;

            int hL = Height(p.lchild);
            int hR = Height(p.rchild);

            if (hL > hR)
                return 1 + hL;
            else
                return 1 + hR;
        }

        public void CreateTree()
        {
            root = new Node('P');
            root.lchild = new Node('Q');
            root.rchild = new Node('R');
            root.lchild.lchild = new Node('A');
            root.lchild.rchild = new Node('B');
            root.rchild.lchild = new Node('X');
        }



    }
}
