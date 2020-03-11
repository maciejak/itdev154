using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int choice1;
            try
            {
                while (true)
                {
                    choice1 = GetMenuChoice();
                    Clear();

                    if (choice1 == 5)
                        break;

                    switch (choice1)
                    {
                        case 1:
                            StackArSubMenu();
                            break;
                        case 2:
                            StackLiSubMenu();
                            break;
                        case 3:
                            QueueArSubMenu();
                            break;
                        case 4:
                            QueueLiSubMenu();
                            break;
                        default:
                            WriteLine("You have entered an invalid selection. Please try again.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"An error has occured:{ex.Message}\n{ex.StackTrace}");
            }
        }

        static void StackArSubMenu()
        {
            StackArray sa = new StackArray(8);
            int choice2;
            int x;

            try
            {
                while (true)
                {
                    choice2 = StackSubMenuChoice();
                    Clear();

                    if (choice2 == 6)
                        break;

                    switch (choice2)
                    {
                        case 1:
                            Write("Enter the element to be pushed: ");
                            x = Convert.ToInt32(ReadLine());
                            sa.Push(x);
                            break;
                        case 2:
                            x = sa.Pop();
                            Write($"Popped element is {x}");
                            break;
                        case 3:
                            WriteLine($"Element at top is {sa.Peek()}");
                            break;
                        case 4:
                            sa.Display();
                            break;
                        case 5:
                            WriteLine($"Size of stack is {sa.Size()}");
                            break;
                        case 6:
                            break;
                        default:
                            WriteLine("You have entered an invalid selection. Please try again.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"An error has occured:{ex.Message}\n{ex.StackTrace}");
            }
        }

        static void StackLiSubMenu()
        {
            StackLinkedList sl = new StackLinkedList();
            int choice2, x;

            try
            {
                while (true)
                {
                    choice2 = StackSubMenuChoice();
                    Clear();

                    if (choice2 == 6)
                        break;

                    switch (choice2)
                    {
                        case 1:
                            Write("Enter the element to be pushed: ");
                            x = Convert.ToInt32(ReadLine());
                            sl.Push(x);
                            break;
                        case 2:
                            x = sl.Pop();
                            WriteLine($"Popped element is {x}");
                            break;
                        case 3:
                            WriteLine($"Element at top is {sl.Peek()}");
                            break;
                        case 4:
                            sl.Display();
                            break;
                        case 5:
                            WriteLine($"Size of stack is {sl.Size()}");
                            break;
                        case 6:
                            break;
                        default:
                            WriteLine("You have entered an invalid selection. Please try again.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"An error has occured:{ex.Message}\n{ex.StackTrace}");
            }
        }

        static void QueueArSubMenu()
        {
            int choice2, x;
            QueueArray qa = new QueueArray(8);

            try
            {
                while (true)
                {
                    choice2 = QueueSubMenuChoice();
                    Clear();

                    if (choice2 == 6)
                        break;

                    switch (choice2)
                    {
                        case 1:
                            Write("Enter the number to be inserted: ");
                            x = Convert.ToInt32(ReadLine());
                            qa.Insert(x);                      
                            break;
                        case 2:
                            x = qa.Delete();
                            WriteLine($"Element deleted is {x}");
                            break;
                        case 3:
                            WriteLine($"Element at the front is {qa.Peek()}");
                            break;
                        case 4:
                            qa.Display();
                            break;
                        case 5:
                            WriteLine($"Size of queue is {qa.Size()}");
                            break;
                        case 6:
                            break;
                        default:
                            WriteLine("You have entered an invalid selection. Please try again.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"An error has occured:{ex.Message}\n{ex.StackTrace}");
            }
        }

        static void QueueLiSubMenu()
        {
            int choice2, x;
            QueueLinkedList ql = new QueueLinkedList();

            try
            {
                while (true)
                {
                    choice2 = QueueSubMenuChoice();
                    Clear();

                    if (choice2 == 6)
                        break;

                    switch (choice2)
                    {
                        case 1:
                            Write("Enter the number to be inserted: ");
                            x = Convert.ToInt32(ReadLine());
                            ql.Insert(x);
                            break;
                        case 2:
                            x = ql.Delete();
                            WriteLine($"Element deleted is {x}");
                            break;
                        case 3:
                            WriteLine($"Element at the front is {ql.Peek()}");
                            break;
                        case 4:
                            ql.Display();
                            break;
                        case 5:
                            WriteLine($"Size of queue is {ql.Size()}");
                            break;
                        case 6:
                            break;
                        default:
                            WriteLine("You have entered an invalid selection. Please try again.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"An error has occured:{ex.Message}\n{ex.StackTrace}");
            }
        }

        private static int GetMenuChoice()
        {
            WriteLine();
            WriteLine("Welcome.");
            WriteLine("1. Array Implementation of Stack");
            WriteLine("2. Linked List Implementation of Stack");
            WriteLine("3. Array Implementation of Queue");
            WriteLine("4. Linked List Implementation of Queue");
            WriteLine("5. Exit");
            Write("Please Enter Your Selection: ");
            int choice1 = Convert.ToInt32(ReadLine());
            WriteLine();
            return choice1;
        }

        private static int StackSubMenuChoice()
        {
            WriteLine();
            WriteLine("1. Push an element on the stack");
            WriteLine("2. Pop an element from the stack");
            WriteLine("3. Display the top element");
            WriteLine("4. Display all the stack elements");
            WriteLine("5. Display the size of the stack");
            WriteLine("6. Return to main menu");
            Write("Please Enter Your Selection: ");
            int choice2 = Convert.ToInt32(ReadLine());
            WriteLine();
            return choice2;
        }

        private static int QueueSubMenuChoice()
        {
            WriteLine();
            WriteLine("1. Insert an element in the queue");
            WriteLine("2. Delete an element in the queue");
            WriteLine("3. Display an element at the front");
            WriteLine("4. Display all elements in the queue");
            WriteLine("5. Display the size of the queue");
            WriteLine("6. Return to main menu");
            Write("Please Enter Your Selection: ");
            int choice2 = Convert.ToInt32(ReadLine());
            WriteLine();
            return choice2;
        }
    }
}
