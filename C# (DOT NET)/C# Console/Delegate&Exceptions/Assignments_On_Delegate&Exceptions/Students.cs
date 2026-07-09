using System;
using System.Collections.Generic;
using System.Text;

namespace Stu
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(int rollNo, string name, int marks)
        {
            RollNo = rollNo;
            Name = name;
            Marks = marks;
        }
    }
}
