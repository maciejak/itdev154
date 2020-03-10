using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, x;
            LinkedList list = new LinkedList();
            list.CreateList();

            while (true)
            {
                choice = GetUserSelection();
                if (choice == 0)
                    break;

                switch(choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        Write("Enter the element to be inserted at the beginning: ");
                        data = Convert.ToInt32(ReadLine());
                        list.InsertAtBeginning(data);
                        break;
                    case 3:
                        list.DeletFirstNode();
                        break;
                    case 4:
                        Write("Enter the element to be inserted at the end: ");
                        data = Convert.ToInt32(ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 5:
                        list.DeleteLastNode();
                        break;
                    case 6:
                        Write("Enter the position of the new element: ");
                        x = Convert.ToInt32(ReadLine());
                        WriteLine();
                        Write("Enter the element to be inserted at position " + x + ": ");
                        data = Convert.ToInt32(ReadLine());
                        list.InsertAtPosition(x, data);
                        break;
                    case 7:
                        Write("Enter the position of the element to be removed: ");
                        x = Convert.ToInt32(ReadLine());
                        list.RemoveAtPosition(x);
                        break;
                    case 8:
                        list.ReverseList();
                        break;
                    case 9:
                        list.BubbleSortExData();
                        break;
                    case 10:
                        list.BubbleSortExLinks();
                        break;
                    case 11:
                        Write("Enter the element at which the cycle should be inserted: ");
                        data = Convert.ToInt32(ReadLine());
                        list.InsertCycle(data);
                        break;
                    case 12:
                        if (list.HasCycle())
                            WriteLine("List has a cycle.");
                        else
                            WriteLine("List does not have a cycle.");
                        break;
                    case 13:
                        list.RemoveCycle();
                        break;
                    default:
                        Write("You have entered an invalid choice.");
                        break;
                }
                WriteLine();
            }
            WriteLine("Exiting");
        }
        
        public static int GetUserSelection()
        {
            int choice;
            WriteLine();
            WriteLine("1. Display List");
            WriteLine("2. Add Element at Beginning of List");
            WriteLine("3. Delete First Element");
            WriteLine("4. Add Element at End of List");
            WriteLine("5. Delete Last Element");
            WriteLine("6. Add Element at a Given Position");
            WriteLine("7. Remove Element at a Given Position");
            WriteLine("8. Reverse List");
            WriteLine("9. Bubble Sort by Exchanging Data");
            WriteLine("10. Bubble Sort by Exchanging Links");
            WriteLine("11. Insert Cycle");
            WriteLine("12. Detect Cycle");
            WriteLine("13. Remove Cycle");
            WriteLine("0. Quit");
            WriteLine();
            Write("Please Enter Your Selection: ");
            choice = Convert.ToInt32(ReadLine());
            WriteLine();
            return choice;
        }
    }
}
