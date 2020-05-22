using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class EmployeeRecord
    {
        private int employeeID;
        private String employeeFName;
        private String employeeLName;
        private double hourlyWage;

        public EmployeeRecord(int id, String fName, String lName, double wage)
        {
            employeeID = id;
            employeeFName = fName;
            employeeLName = lName;
            hourlyWage = wage;
        }

        public int GetEmployeeID()
        {
            return employeeID;
        }

        public void SetEmployeeID(int id)
        {
            employeeID = id;
        }

        public override String ToString()
        {
            return ($"\tEmployee ID: {employeeID}\n\tEmployee Name: {employeeFName} {employeeLName}\n\tEmployee Wage: ${hourlyWage}");
        }
    }
}
