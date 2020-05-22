using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAddressing
{
    class HashTable
    {
        private StudentRecord[] array;
        private int m; //size of array
        int n; //number of records

        public HashTable() : this(11) //constructor - if size of table is not created, make a table of size 11
        {  }

        public HashTable(int tableSize) //constructor
        {
            m = tableSize;
            array = new StudentRecord[m];
            n = 0;
        }

        int hash(int key)
        {
            return (key % m);
        }

        public void Insert(StudentRecord newRecord) //linear probing technique (1:39)
        {
            int key = newRecord.GetStudentID();
            int h = hash(key);

            int location = h;

            for(int i = 1; i < m; i++)
            {
                if(array[location] == null || array[location].GetStudentID() == -1)
                {
                    array[location] = newRecord;
                    n++;
                    return;
                }

                if (array[location].GetStudentID() == key)
                    throw new System.InvalidOperationException("Duplicate Key");

                location = (h + i) % m;         
            }
            Console.WriteLine("Table is full : Record can't be inserted");
        }

        public StudentRecord Search(int key)
        {
            int h = hash(key);
            int location = h;

            for(int i = 1; i < m; i++)
            {
                if (array[location] == null)
                    return null;
                if (array[location].GetStudentID() == key)
                    return array[location];
                location = (h + i) % m; //linear probing
            }
            return null;
        }

        public void DisplayTable()
        {
            for (int i = 0; i < m; i ++)
            {
                Console.Write($"[{i}] --> ");

                if (array[i] != null && array[i].GetStudentID() != -1)
                    Console.WriteLine(array[i].ToString());
                else
                    Console.WriteLine("___");
            }
        }

        public StudentRecord Delete(int key)
        {
            int h = hash(key);
            int location = h;

            for(int i = 0; i < m; i++)
            {
                if (array[location] == null)
                    return null;
                if (array[location].GetStudentID() == key)
                {
                    StudentRecord temp = array[location];
                    array[location].SetStudentID(-1);
                    n--;
                    return temp;
                }
                location = (h + i) % m;
            }
            return null;
        }
    }
}
