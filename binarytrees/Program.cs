using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            bt.CreateTree();

            bt.Display();
            WriteLine();

            WriteLine("Preorder : ");
            bt.Preorder();
            WriteLine();

            WriteLine("Inorder : ");
            bt.Inorder();
            WriteLine();

            WriteLine("Postorder : ");
            bt.Postorder();
            WriteLine();

            WriteLine("Level Order : ");
            bt.LevelOrder();
            WriteLine();

            WriteLine($"Height of tree is {bt.Height()}");
            ReadLine();
        }
    }
}
