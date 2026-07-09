using exp;
using Stu;
using System;

namespace StuM
{
    class StudentManager
    {
        Predicate<int> isPassed = marks => marks > 49;

        public string Evaluate(Student student)
        {
            if (student.Marks < 0 || student.Marks > 100)
            {
                throw new InvalidMarksException("Marks should be between 0 and 100.");
            }

            if (isPassed(student.Marks))
            {
                return "Passed";
            }

            return "Failed";
        }
    }
}