using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System_LINQToObj
{
    public class StudentManage
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }
    public static class StudentRepository
    {
        public static List<StudentManage> GetStudentDetails()
        {
            return new List<StudentManage>
            {
                new StudentManage { StudentId = 101, Name = "Rahul",   Course = "C#",      Age = 20, Marks = 85 },
                new StudentManage { StudentId = 102, Name = "Priya",   Course = "BCA",    Age = 21, Marks = 90 },
                new StudentManage { StudentId = 103, Name = "Amit",    Course = "Python",  Age = 22, Marks = 78 },
                new StudentManage { StudentId = 104, Name = "Sneha",   Course = "C++",     Age = 20, Marks = 88 },
                new StudentManage { StudentId = 105, Name = "Kiran",   Course = "SQL",     Age = 23, Marks = 81 },
                new StudentManage { StudentId = 106, Name = "Anjali",  Course = "Java",    Age = 21, Marks = 92 },
                new StudentManage { StudentId = 107, Name = "Rakesh",  Course = "BCA",  Age = 22, Marks = 75 },
                new StudentManage { StudentId = 108, Name = "Meena",   Course = "C#",      Age = 20, Marks = 89 },
                new StudentManage { StudentId = 109, Name = "Arjun",   Course = "SQL",     Age = 21, Marks = 84 },
                new StudentManage { StudentId = 110, Name = "Pooja",   Course = "BCA",    Age = 22, Marks = 87 },
                new StudentManage { StudentId = 111, Name = "Vijay",   Course = "C++",     Age = 23, Marks = 76 },
                new StudentManage { StudentId = 112, Name = "Divya",   Course = "Python",  Age = 20, Marks = 95 },
                new StudentManage { StudentId = 113, Name = "Nikhil",  Course = "C#",      Age = 21, Marks = 82 },
                new StudentManage { StudentId = 114, Name = "Kavya",   Course = "SQL",     Age = 22, Marks = 91 },
                new StudentManage { StudentId = 115, Name = "Suresh",  Course = "Java",    Age = 23, Marks = 79 },
                new StudentManage { StudentId = 116, Name = "Rohit",    Course = "BCA", Age = 20, Marks = 86 },
                new StudentManage { StudentId = 117, Name = "Neha",     Course = "C#",     Age = 22, Marks = 93 },
                new StudentManage { StudentId = 118, Name = "Akash",    Course = "Java",   Age = 21, Marks = 74 },
                new StudentManage { StudentId = 119, Name = "Swathi",   Course = "BCA",    Age = 23, Marks = 88 },
                new StudentManage { StudentId = 120, Name = "Harsha",   Course = "BCA",    Age = 20, Marks = 80 }
            };
        }
    }
}
