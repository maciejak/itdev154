using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bt = new BinarySearchTree();
            int choice, x;

            while(true)
            {
                WriteLine();
                WriteLine("1. Display Tree");
                WriteLine("2. Search");
                WriteLine("3. Add a New Node");
                WriteLine("4. Delete a Node");
                WriteLine("5. Preorder Traversal");
                WriteLine("6. Inorder Traversal");
                WriteLine("7. Postorder Traversal");
                WriteLine("8. Height of Tree");
                WriteLine("9. Find Minimum Key");
                WriteLine("10. Find Maximum Key");
                WriteLine("11. Quit");

                Write("Please enter your selection: ");
                choice = Convert.ToInt32(ReadLine());
                WriteLine();

                if (choice == 11)
                    break;

                switch(choice)
                {
                    case 1:
                        bt.Display();
                        break;
                    case 2:
                        Write("Enter the key to be searched: ");
                        x = Convert.ToInt32(ReadLine());

                        if (bt.Search(x))
                            WriteLine("Key found.");
                        else
                            WriteLine("Key not found.");
                        break;
                    case 3:
                        Write("Enter the key to be inserted: ");
                        x = Convert.ToInt32(ReadLine());
                        bt.Insert(x);
                        break;
                    case 4:
                        Write("Enter the key to be deleted: ");
                        x = Convert.ToInt32(ReadLine());
                        bt.Delete(x);
                        break;
                    case 5:
                        bt.Preorder();
                        break;
                    case 6:
                        bt.Inorder();
                        break;
                    case 7:
                        bt.Postorder();
                        break;
                    case 8:
                        WriteLine($"Height of tree is {bt.Height()}");
                        break;
                    case 9:
                        WriteLine($"Minimum key is {bt.Min()}");
                        break;
                    case 10:
                        WriteLine($"Maximum key is {bt.Max()}");
                        break;
                    default:
                        WriteLine("Please make a valid selection.");
                        break;
                }
            }
        }
    }
}
