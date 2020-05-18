using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, i, n;
            int[] a = new int[20];

            while(true)
            {
                WriteLine();
                Write("Enter the total number of elements in the array: ");
                n = Convert.ToInt32(ReadLine());

                for (i = 0; i < n; i++)
                {
                    Write($"Enter element {(i + 1)}: ");
                    a[i] = Convert.ToInt32(ReadLine());
                }

                WriteLine();
                WriteLine("Array is: ");
                for (i = 0; i < n; i++)
                    Write($"{a[i]} ");
                WriteLine();

                WriteLine();
                WriteLine("Would you like to: ");

                WriteLine("1. Bubble Sort");
                WriteLine("2. Quick Sort");
                WriteLine("3. Quit");
                WriteLine();

                Write("Please enter your selection: ");
                choice = Convert.ToInt32(ReadLine());
                WriteLine();

                if (choice == 3)
                    break;

                switch(choice)
                {
                    case 1:
                        BubbleSort.Sort(a, n);
                        WriteLine("Sorted Array is: ");
                        for (i = 0; i < n; i++)
                            Write($"{a[i]} ");
                        WriteLine();
                        break;
                    case 2:
                        QuickSort.Sort(a, n);
                        WriteLine("Sorted Array is: ");
                        for (i = 0; i < n; i++)
                            Write($"{a[i]} ");
                        WriteLine();
                        break;
                    default:
                        WriteLine("Please enter a valid selection.");
                        break;
                }
            }
        }
    }
}
