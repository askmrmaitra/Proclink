namespace Student_Management_System_LINQToObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GreaterMarksMethodSyntax();
            //StudentQueryGetCourse();
            //getCourseMethodSyntax();
            //MarksDescMethodSyntax();
            //MarksDescQuerySyntax();
            //GroupByCourse();
            //LINQAggFunctions();

            Console.WriteLine("Press Enter to Terminate");
            Console.ReadKey();
        }
        static void GreaterMarksMethodSyntax()
        {
            var students = StudentRepository.GetStudentDetails();

            var ans = students.Where(st => st.Marks > 80);

            Console.WriteLine("\n Students Greater than 80 Marks: \n");
            foreach (var student in ans)
            {
                Console.WriteLine($"{student.StudentId,-10} {student.Name,-10} {student.Marks,-10}");
            }

            Console.WriteLine();
        }

        static void StudentQueryGetCourse()
        {
            Console.WriteLine("\n EMPLOYEE - QUERY SYNTAX \n");

            var students = StudentRepository.GetStudentDetails();

            var ans =
                  from student in students
                  where student.Course == "BCA"
                  select student;

            foreach (var student in ans)
            {
                Console.WriteLine($"{student.StudentId,-10} {student.Name,-10} {student.Age,-10}");
            }
            Console.WriteLine();
        }
        static void getCourseMethodSyntax()
        {
            var students = StudentRepository.GetStudentDetails();

            var ans = students.Where(st => st.Course == "BCA");

            Console.WriteLine("\n Students belongs to BCA Course: ");
            foreach (var student in ans)
            {
                Console.WriteLine($"{student.StudentId,-10} {student.Name,-10} {student.Age,-10}");
            }

            Console.WriteLine();
        }

        static void MarksDescMethodSyntax()
        {
            var students = StudentRepository.GetStudentDetails();

            var result = students.OrderByDescending(st => st.Marks);

            Console.WriteLine("\n Students Whose Marks are in Desc Order : \n");
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name,-10} {student.Marks,-10}");
            }

            Console.WriteLine();
        }
        static void MarksDescQuerySyntax()
        {
            var students = StudentRepository.GetStudentDetails();

            var result =
                     from student in students
                     orderby student.Marks descending
                     select student;

            Console.WriteLine("\n Students Whose Marks are in Desc Order : \n");
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name,-10} {student.Marks,-10}");
            }

            Console.WriteLine();
        }

        static void GroupByCourse()
        {
            var students = StudentRepository.GetStudentDetails();

            var result = students.GroupBy(stu => stu.Course);

            Console.WriteLine("\nStudents Grouped by Course:\n");

            foreach (var group in result)
            {
                Console.WriteLine($"\nDepartment : {group.Key}");

                Console.WriteLine($"Total Students Count : {group.Count()}");
                
            }
        }

        static void LINQAggFunctions()
        {
            Console.WriteLine("\nAGGREGATE FUNCTIONS\n");

            var students = StudentRepository.GetStudentDetails();

            Console.WriteLine($"Highest Marks :  {students.Max(st => st.Marks)}");
            Console.WriteLine($"Lowest Marks  :  {students.Min(st => st.Marks)}");
            Console.WriteLine($"Average Marks : {students.Average(st => st.Marks)}");
            Console.WriteLine($"Total Students: {students.Count()}");
            Console.WriteLine($"Sum of Marks  : {students.Sum(st => st.Marks)}");

            Console.WriteLine();
        }
    }
}
