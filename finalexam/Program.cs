using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, choice;
            String fName, lName;
            double wage;

            WriteLine("Welcome to Employee Manager.");
            Write("Please enter the size of the employee catalog: ");
            int size = Convert.ToInt32(ReadLine());

            RecordBook table = new RecordBook(size);
            Clear();

            while (true)
            {
                WriteLine(" _____________________");
                WriteLine("|                     |");
                WriteLine("| 1. Insert a Record  |");
                WriteLine("| 2. Delete a Record  |");
                WriteLine("| 3. Display Records  |");
                WriteLine("| 4. Exit             |");
                WriteLine("|_____________________|");

                Write("--> Enter your choice: ");
                choice = Convert.ToInt32(ReadLine());
                Clear();

                if (choice == 4)
                    break;

                switch (choice)
                {
                    case 1:
                        Write("Enter employee ID: ");
                        id = Convert.ToInt32(ReadLine());
                        Write("Enter employee first name: ");
                        fName = ReadLine();
                        Write("Enter employee last name: ");
                        lName = ReadLine();
                        Write("Enter employee hourly wage: ");
                        wage = Convert.ToDouble(ReadLine());

                        EmployeeRecord aRecord = new EmployeeRecord(id, fName, lName, wage);
                    
                        table.Insert(aRecord);
                        Clear();
                        break;

                    case 2:
                        Write("Enter an Employee ID to be deleted: ");
                        id = Convert.ToInt32(ReadLine());
                        table.Delete(id);
                        Clear();
                        break;

                    case 3:
                        table.DisplayRecords();
                        break;
                }
            }
        }
    }
}
