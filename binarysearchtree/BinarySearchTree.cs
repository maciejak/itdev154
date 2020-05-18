using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return (root == null);
        }

        public void Insert(int x)
        {
            root = Insert(root, x);
        }

        private Node Insert(Node p, int x)
        {
            if (p == null)
                p = new Node(x);
            else if (x < p.info)
                p.lchild = Insert(p.lchild, x);
            else if (x > p.info)
                p.rchild = Insert(p.rchild, x);
            else
                WriteLine($"{x} already present in tree.");
            return p;
        }

        public void Insert1(int x)
        {
            Node p = root;
            Node par = null;

            while (p != null)
            {
                par = p;
                if (x < p.info)
                    p = p.lchild;
                else if (x > p.info)
                    p = p.rchild;
                else
                {
                    WriteLine($"{x} already present in tree.");
                    return;
                }
            }

            Node temp = new Node(x);

            if (par == null)
                root = temp;
            else if (x < par.info)
                par.lchild = temp;
            else
                par.rchild = temp;
        }

        public bool Search(int x)
        {
            return (Search(root, x) != null);
        }

        private Node Search(Node p, int x)
        {
            if (p == null)
                return null; //key not found
            if (x < p.info) //search l subtree
                return Search(p.lchild, x); 
            if (x > p.info) //search r subtree
                return Search(p.rchild, x);
            return p; //key found
        }

        public bool Search1(int x)
        {
            Node p = root;

            while( p != null)
            {
                if (x < p.info)
                    p = p.lchild; //move to left child
                if (x > p.info)
                    p = p.rchild; //move to right child
                else //if x is found
                    return true;
            }
            return false;
        }

        public void Delete(int x)
        {
            root = Delete(root, x);
        }

        private Node Delete(Node p, int x)
        {
            Node ch, s;

            if(p == null)
            {
                WriteLine($"{x} not found.");
                return p;
            }
            if (x < p.info) //delete from left subtree
                p.lchild = Delete(p.lchild, x);
            else if (x > p.info) //delete from right subtree
                p.rchild = Delete(p.rchild, x);
            else //key to be deleted is found
            {
                if(p.lchild != null && p.rchild != null) //2 children
                {
                    s = p.rchild;
                    while (s.lchild != null)
                        s = s.lchild;
                    p.info = s.info;
                    p.rchild = Delete(p.rchild, s.info);
                }
                else //1 child or no child
                {
                    if (p.lchild != null) //only left child
                        ch = p.lchild;
                    else //only right child or no child
                        ch = p.rchild;
                    p = ch;
                }
            }
            return p;
        }

        public void Delete1(int x)
        {
            Node p = root;
            Node par = null;

            while(p != null)
            {
                if (x == p.info)
                    break;
                par = p;
                if (x < p.info)
                    p = p.lchild;
                else
                    p = p.rchild;
            }

            if(p == null)
            {
                WriteLine($"{x} is not found.");
                return;
            }

            //case c: 2 children ; find successor and its parent

            Node s, ps;

            if(p.lchild != null && p.rchild != null)
            {
                ps = p;
                s = p.rchild;
                while(s.lchild != null)
                {
                    ps = s;
                    s = s.lchild;
                }
                p.info = s.info;
                p = s;
                par = ps;
            }

            //case b & case a: 1 or no child
            Node ch;
            if (p.lchild != null) //node to be deleted has left child
                ch = p.lchild;
            else //node to be deleted has right child or no child
                ch = p.rchild;

            if (par == null) //node to be deleted is root node
                root = ch;
            else if (p == par.lchild) //node is left child of its parent
                par.lchild = ch;
            else //node is right child of its parent
                par.rchild = ch;
        }

        public int Min()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Tree is empty.");
            return Min(root).info;
        }

        private Node Min(Node p)
        {
            if (p.lchild == null)
                return p;
            return Min(p.lchild);
        }

        public int Max()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Tree is empty.");
            return Max(root).info;
        }

        private Node Max(Node p)
        {
            if (p.rchild == null)
                return p;
            return Max(p.rchild);
        }

        public int Min1()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Tree is empty.");
            Node p = root;
            while (p.lchild != null)
                p = p.lchild;
            return p.info;
        }

        public int Max1()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Tree is empty.");
            Node p = root;
            while (p.rchild != null)
                p = p.rchild;
            return p.info;
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
    }
}
