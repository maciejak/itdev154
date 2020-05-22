using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FinalExam
{
    class HashTable
    {
        private EmployeeRecord[] array;
        private int s; //size of array
        int n; //number of records

        public HashTable() : this(10) //constructor - if size of table is not created, make a table of size 11
        { }

        public HashTable(int tableSize) //constructor
        {
            s = tableSize;
            array = new EmployeeRecord[s];
            n = 0;
        }

        int hash(int key)
        {
            return (key % s);
        }

        public void Insert(EmployeeRecord newRecord) //linear probing technique (1:39)
        {
            int key = newRecord.GetEmployeeID();
            int h = hash(key);

            int location = h;

            for (int i = 1; i < s; i++)
            {
                if (array[location] == null || array[location].GetEmployeeID() == -1)
                {
                    array[location] = newRecord;
                    n++;
                    return;
                }

                if (array[location].GetEmployeeID() == key)
                    throw new System.InvalidOperationException("Duplicate ID");

                location = (h + i) % s;
            }
            Console.WriteLine("Table is full : Record can't be inserted");
        }

        public EmployeeRecord Search(int key)
        {
            int h = hash(key);
            int location = h;

            for (int i = 1; i < s; i++)
            {
                if (array[location] == null)
                    return null;
                if (array[location].GetEmployeeID() == key)
                    return array[location];
                location = (h + i) % s; 
            }
            return null;
        }

        public void DisplayTable()
        {
            WriteLine("--> Employee Records: \n");
            for (int i = 0; i < s; i++)
            {
                Write($"[{i + 1}] ");

                if (array[i] != null && array[i].GetEmployeeID() != -1)
                    WriteLine($"{array[i].ToString()}\n");
                else
                    WriteLine("___\n");
            }
        }

        public EmployeeRecord Delete(int key)
        {
            int h = hash(key);
            int location = h;

            for (int i = 0; i < s; i++)
            {
                if (array[location] == null)
                    return null;
                if (array[location].GetEmployeeID() == key)
                {
                    EmployeeRecord temp = array[location];
                    array[location].SetEmployeeID(-1);
                    n--;
                    return temp;
                }
                location = (h + i) % s;
            }
            return null;
        }
    }
}

