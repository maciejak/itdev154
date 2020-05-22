using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OpenAddressing
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, choice;
            String name;

            Write("Enter initial size of table: ");
            int size = Convert.ToInt32(ReadLine());

            HashTable table = new HashTable(size);

            while(true)
            {
                WriteLine("1. Insert a Record");
                WriteLine("2. Search a Record");
                WriteLine("3. Delete a Record");
                WriteLine("4. Display Table");
                WriteLine("5. Exit");

                Write("Enter your choice: ");
                choice = Convert.ToInt32(ReadLine());

                if (choice == 5)
                    break;

                switch (choice)
                {
                    case 1:
                        Write("Enter student ID: ");
                        id = Convert.ToInt32(ReadLine());
                        Write("Enter student name: ");
                        name = ReadLine();

                        StudentRecord aRecord = new StudentRecord(id, name);

                        table.Insert(aRecord);
                        break;

                    case 2:
                        Write("Enter a key to be searched: ");
                        id = Convert.ToInt32(ReadLine());
                        aRecord = table.Search(id);

                        if (aRecord == null)
                            WriteLine("Key not Found");
                        else
                            WriteLine(aRecord.ToString());
                        break;

                    case 3:
                        Write("Enter a key to be deleted: ");
                        id = Convert.ToInt32(ReadLine());
                        table.Delete(id);
                        break;

                    case 4:
                        table.DisplayTable();
                        break;
                }
            }
        }
    }
}
