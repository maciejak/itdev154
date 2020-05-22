using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FinalExam
{
    class RecordBook
    {
        private EmployeeRecord[] array;
        private int s; 
        int n; 

        public RecordBook() : this(10)
        { }

        public RecordBook(int tableSize) 
        {
            s = tableSize;
            array = new EmployeeRecord[s];
            n = 0;
        }

        int hash(int key)
        {
            return (key % s);
        }

        public void Insert(EmployeeRecord newRecord) 
        {
            int key = newRecord.GetEmployeeID(); //C
            int h = hash(key);                   //C

            int location = h;                    //C

            for (int i = 1; i < s; i++)          //n
            {
                if (array[location] == null || array[location].GetEmployeeID() == -1) //C
                {
                    array[location] = newRecord; //C
                    n++;                         //C
                    return;
                }

                if (array[location].GetEmployeeID() == key)                     //C
                    throw new System.InvalidOperationException("Duplicate ID"); //C

                location = (h + i) % s; //C
            }
            Console.WriteLine("Table is full : Record can't be inserted"); //C
        } // 10C + n = O(n)

        public void DisplayTable()
        {
            WriteLine("--> Employee Records: \n"); //C
            for (int i = 0; i < s; i++)            //n
            {
                Write($"[{i + 1}] ");              //C

                if (array[i] != null && array[i].GetEmployeeID() != -1) //C
                    WriteLine($"{array[i].ToString()}\n");              //C
                else
                    WriteLine("___\n"); //C
            }
        } //5C + n = O(n)

        public EmployeeRecord Delete(int key)
        {
            int h = hash(key);  //C
            int location = h;   //C

            for (int i = 0; i < s; i++) //n
            {
                if (array[location] == null)                //C
                    return null;
                if (array[location].GetEmployeeID() == key) //C
                {
                    EmployeeRecord temp = array[location];  //C
                    array[location].SetEmployeeID(-1);      //C
                    n--;                                    //C
                    return temp;
                }
                location = (h + i) % s; //C
            }
            return null;
        } //8C + n = O(n)
    }
}

