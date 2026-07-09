using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    public class Student
    {

        public int id { get; set; }
        public string Name { get; set; }

    }
    public class StudentManagement
    {
        List<Student> students = new List<Student>();
       public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> FetchStudents()
        {
            return students;
        }
    }
}
