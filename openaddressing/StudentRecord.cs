using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAddressing
{
    class StudentRecord
    {
        private int studentID;
        private String studentName;

        public StudentRecord(int i, String name)
        {
            studentID = i;
            studentName = name;
        }

        public int GetStudentID()
        {
            return studentID;
        }

        public void SetStudentID(int i)
        {
            studentID = i;
        }

        public String ToString()
        {
            return ($"{studentID} {studentName}");
        }
    }
}
